//using System.ComponentModel;

//An Invoice class might have the responsibility of calculating various amounts based on its data. In that case, it probably shouldn’t know how to retrieve this data from a database, or how to format an invoice for print or display or logging, sending Email, etc.

//So in the answer preload, you can see the Invoice class that contains almost the whole probable logic. This Invoice class has its own responsibility i.e. Add, Delete invoices, and also has extra activities like logging and Sending emails as well.

//You have to make the refactoring according to the SRP so that the Invoice class can happily delegate additional activities to other types.This way Invoice class can concentrate on Invoice related activities.

public class Invoice : MailSender
{
    public long Amount { get; set; }
    public DateTime InvoiceDate { get; set; }
    public void FileLogger()
    {
        // Code for initialization i.e. Creating Log file with specified  
        // details
    }
    public void Add()
    {
        Console.WriteLine("Adding amount...");
        // Code for adding invoice
        // Once Invoice has been added , send mail 
        string mailMessage = "Your invoice is ready.";
        SendEmail(mailMessage);
    }

    public void Delete()
    {
        Console.WriteLine("Deleting amount...");
    }
}
public class MailSender
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public void SendEmail(string mailMessage)
    {
        Console.WriteLine("Sending Email: {0}", mailMessage);
        // Code for getting Email setting and send invoice mail

    }
}
public class FileLogger : IFileLogger
{
    public void Check() { }
    public void Debug() { }
    public void Info() { }

}
interface IFileLogger
{
    public void Check();
    public void Debug();
    public void Info();

}