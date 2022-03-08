using Vonage;
using Vonage.Request;

namespace TestSMSApp
{
    public class SmsSender
    {
        public const string API_KEY ="3e17d55e";
        public const string API_SECRET ="daDPyRfZWu1pRWsT";
        public static void SendSMS(){
            var vonaClient = GetVonageClient();
            // TODO: Send the sms
            var response = vonaClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
                    {
                        To = "18297259060",
                        From ="FaoSoft",
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