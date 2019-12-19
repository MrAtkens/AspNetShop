using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using AspNetShop.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetShop.Services
{
    public class FirebaseNotificationService : INotificationService
    {
        public async Task SendInformationMessage(List<string> ids, string message)
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.GetApplicationDefault()
            });

            List<Message> messages = new List<Message>();

            foreach (var id in ids)
            {
                messages.Add(new Message
                {
                    Token = id,
               
                    Notification = new Notification
                    {
                        Title = "Уведомление",
                        Body = message
                    }
                });
            }
            

            await FirebaseMessaging.DefaultInstance.SendAllAsync(messages);
        }
    }
}
