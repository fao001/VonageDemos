using Vonage;
using Vonage.Request;

namespace TestSMSApp
{
    public class SmsSender
    {
        public const string API_KEY ="";
        public const string API_SECRET ="";
        public static void SendSMS(){
            var vonaClient = GetVonageClient();
            // TODO: Send the sms
            var response = vonaClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
                    {
                        To = "",
                        From ="From Title",
                        Text ="Mensaje de prueba...usando vonage API's"
                    }
                );
        }
        private static VonageClient GetVonageClient(){
            var credentials = Credentials.FromApiKeyAndSecret(API_KEY,API_SECRET);
            return new VonageClient(credentials);
        }
    }
}