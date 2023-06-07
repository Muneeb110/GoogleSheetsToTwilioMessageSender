using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Spreadsheets;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ReadGoogleSheetsAndTwilioMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scopes = new List<string>();
            var credential = GoogleCredential.FromStream(new FileStream("C:\\New folder\\snappy-surf-302308-1bee9e678a8f.json", FileMode.Open)).CreateScoped(scopes);
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "test",
            });

            // Define request parameters.  
            String spreadsheetId = "asdasdjaosdapsd-cVRicJ9iYPY";
            String range = "Only Karachi-List";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                                    service.Spreadsheets.Values.Get(spreadsheetId, range);
            // Prints the names and majors of students in a sample spreadsheet:  
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            string a = values[1][0].ToString();
            string b = values[1][1].ToString();
            string c = values[1][2].ToString();


            string accountSid = "asdksapodmasmdpamsdmapsdmp";
            Console.WriteLine("Enter your phone number:");
            string authToken = "edc4879ad2cab88275fb22ad4163575f";

            TwilioClient.Init(accountSid, authToken);
            string toNumber = Console.ReadLine();
            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155231234"),
                body: "" + a + "," + b + "," + c,
                to: new Twilio.Types.PhoneNumber("whatsapp:" + toNumber)
            );

            Console.WriteLine(message.Sid);
            Console.Read();

        }
    }
}
