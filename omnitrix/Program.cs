namespace omnitrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.Create();
            Purchase purchase = new Purchase();
            purchase.Update();
            PurchaseOrder order = new PurchaseOrder();
            order.Delete();
            Category category = new Category();
            category.Delete();
        }
    }
}