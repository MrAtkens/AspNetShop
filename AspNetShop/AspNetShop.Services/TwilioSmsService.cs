using AspNetShop.DTO;
using AspNetShop.Services.Interfaces;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace AspNetShop.Services
{
    public class TwilioSmsService : ISmsService
    {
        public Task<SmsServiceResponseDTO> SendVerificationCode(string phoneNumber, string code)
        {
            const string accountSid = "AC8ae5a37332e855c9f2193b87e052e208";
            const string authToken = "10052bcc88070307ac108f2ad5904336";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Verification code:"+code,
                from: new Twilio.Types.PhoneNumber("+12532317832"),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );


            return Task.FromResult(new SmsServiceResponseDTO{
                StatusCode = 200,
                Message = "Сообщение отправлено"
            });
        }
    }
}
