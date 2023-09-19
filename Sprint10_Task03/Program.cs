//using System.Runtime.InteropServices;

//Let's look at the answer box preload. 

//You have a class Invoice here with a simple InvoiceType property. This property decided if this is a “Final” Or “Proposed” invoice. Depending on the same it calculates a discount.  

//Have a look at the GetDiscount() method which returns a discount accordingly to the value of InvoiceType property.

//The problem is if we add a new invoice type RecurringInvoice with the 10% discount, we need to go and add one more “IF” condition in the GetDiscount() method.In other words, we need to change the Invoice class.

//Among all, a client wants to know the ordinary discount of 1% of the amount in times of season sale.

//If we are changing the Invoice class again and again, we need to ensure that the previous conditions with new ones are tested again, existing clients which are referencing this class are working properly as before.  So whatever the current code is, they are untouched and we just need to test and check the new classes.

//Let’s refactor the solution.


public abstract class Invoice
{
    public abstract double GetDiscount(double sum);
}

public class FinalInvoice : Invoice
{
    public override double GetDiscount(double sum)
    {
        return sum -= sum * 0.03;
    }
}
public class ProposedInvoice : Invoice
{
    public override double GetDiscount(double sum)
    {
        return sum -= sum * 0.05;
    }
}
public class OrdinaryInvoice : Invoice
{
    public override double GetDiscount(double sum)
    {
        return sum -= sum * 0.01;
    }
}

public class RecurringInvoice : Invoice
{
    public override double GetDiscount(double sum)
    {
        return sum -= sum * 0.1;
    }
}
