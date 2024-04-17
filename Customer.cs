using DesignPatterns;

public class Customer
{
    private Card card;
    private double BillAmount;
    public Customer(int type, int amount)
    { 
        BillAmount = amount;
        if (type == 1)
        { 
            card = new MembershipCard();
        } 
        else if (type == 2) 
        {
            card = new EmployeeCard();
        } 
        else {
            card = new NoCard(); 
        }
    } 
    public Card GetCard() {
        return card;
    }

    public void CalculateAmount()
    {
        double discount = card.CalculateDiscount();
        discount = BillAmount * discount;

        Console.WriteLine(BillAmount - discount);

    }

}
