namespace DesignPatterns
{
    public class NoCard : Card
    {
        public override double CalculateDiscount()
        {
            return 0.0;
        }

        public override void GetDiscount()
        {
            Console.WriteLine("No Discount");

        }
    }

}
