namespace DesignPatterns
{
    public class EmployeeCard : Card
    {
        public override double CalculateDiscount()
        {
            return 0.20;
        }

        public override void GetDiscount()
        {
            Console.WriteLine("High Discount");

        }
    }

}
