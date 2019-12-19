using BraintreeHttp;
using AspNetShop.Domain;
using AspNetShop.DTO;
using AspNetShop.Services.Interfaces;
using PayPal.Core;
using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AspNetShop.Services
{
    public class PayPalService : IPaymentService
    {
        private const string APPROVAL_URL = "approval_url";

        public async Task<PaymentServiceResponseDTO> CreateInvoice(Domain.Order order)
        {
            var environment = new SandboxEnvironment("Aay1UvDTKiPQubWqySy0N5eZNXfoKRt-pTIxE3FeQHYBH64VRlr4MRox_-eEsP1IVU5lB87XohzMT2Mv",
            "EGd82QV-Ifk_gjXLEJzH3D-U4XdMTfEcnUz-FYB0vULCtQLZcvRr49yfCrZbtxAki0PhE8ZdX31CWkQO");
            var client = new PayPalHttpClient(environment);
            int totalPrice = 0;

            foreach (var product in order.ProductsInOrder)
            {
                totalPrice += product.Product.Price;
            }

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        ItemList = new ItemList(),
                        Amount = new Amount()
                        {
                            Total = totalPrice.ToString(),
                            Currency = "USD"
                        }
                    }

                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://example.com/cancel",
                    ReturnUrl = "https://example.com/return"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                return new PaymentServiceResponseDTO
                {
                    PaymentUrl = result.Links.FirstOrDefault(link => link.Rel == APPROVAL_URL).Href
                };
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
                return null;
            }
        }
    }
}
