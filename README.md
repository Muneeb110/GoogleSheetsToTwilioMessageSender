# Google Sheets to Twilio Message Sender
This program allows you to read data from a Google Sheets spreadsheet and send a message via Twilio. It is built using .NET Framework 4.7.2 and is a console application.

## Prerequisites
Before running the program, make sure you have the following:

**Google Sheets API credentials:** Obtain the JSON file containing your Google Sheets API credentials and provide the file path in the program code.  
**Twilio account credentials:** Sign up for a Twilio account and obtain your account SID and auth token.
## Installation
Clone or download the repository to your local machine.
Open the solution in Visual Studio.
Restore the necessary NuGet packages, including:
Google.Apis.Sheets.v4
Twilio
## Usage
Provide the path to your Google Sheets API credentials JSON file in the new FileStream() method call.
Update the spreadsheetId and range variables to match your Google Sheets spreadsheet and the specific range of data you want to retrieve.
Set your Twilio account SID and auth token in the accountSid and authToken variables, respectively.
Run the program.
Enter your phone number when prompted.
The program will read the specified data from the Google Sheets spreadsheet and send a WhatsApp message to the provided phone number using Twilio.
Note: Make sure your Google Sheets data and Twilio merge fields match so that the program can map the values correctly.

## License
This project is licensed under the MIT License.
