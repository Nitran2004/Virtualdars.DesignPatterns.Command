namespace Virtualdars.DesignPatterns.Command
{
    // Command Design Pattern
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            Kiosk selfOrderingMachine = new();
            selfOrderingMachine.PlaceOrderItem(MealType.CrispyTender, 4);
            selfOrderingMachine.PlaceOrderItem(MealType.Nugget, 2);
            selfOrderingMachine.PlaceOrderItem(MealType.Chicken, 2);

            
            selfOrderingMachine.RemoveOrderItem(MealType.Nugget);
            selfOrderingMachine.SubmitOrder();

            Console.ReadKey();
        }
    }
}
