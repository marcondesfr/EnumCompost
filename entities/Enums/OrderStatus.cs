namespace EnumComposit.entities.Enums
{
    public enum OrderStatus : int
    {
        Pending_Payment,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}