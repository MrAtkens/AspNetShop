namespace AspNetShop.Domain
{
    public enum OrderStatus
    {
        WaitForPayment,
        Payed,
        Canceled,
        Delivered,
        Finished
    }
}