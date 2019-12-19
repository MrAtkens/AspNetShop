using AspNetShop.Domain;
using AspNetShop.DTO;
using System.Threading.Tasks;

namespace AspNetShop.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentServiceResponseDTO> CreateInvoice(Order order);
    }
}
