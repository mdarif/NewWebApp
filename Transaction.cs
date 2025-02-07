namespace NewWebApp;

// Represents a financial transaction in a bank account
// Stores the amount, date, and any notes associated with the transaction
public class Transaction
{
    // The monetary value of the transaction
    public decimal Amount { get; }
    
    // When the transaction occurred
    public DateTime Date { get; }
    
    // Additional information about the transaction
    public string Notes { get; }

    // Creates a new transaction with the specified amount, date, and note
    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }
}
