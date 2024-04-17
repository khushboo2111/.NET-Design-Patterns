namespace DesignPatterns
{
    public class MembershipCard : Card
    {
        public override double CalculateDiscount()
        {
            return 0.10;
        }

        public override void GetDiscount()
        {
            Console.WriteLine("Low Discount");

        }
    }

}
