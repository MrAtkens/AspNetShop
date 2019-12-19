using AspNetShop.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetShop.Services.Interfaces
{
    public interface ISmsService
    {
        Task<SmsServiceResponseDTO> SendVerificationCode(string phoneNumber, string code);
    }
}
