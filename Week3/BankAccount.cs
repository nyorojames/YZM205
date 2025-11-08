public class BankAccount
{
    private double _balance;
    private DateTime _createDate;

    public int AccountNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public double Balance
    {
        get { return _balance; }

        set
        {
            if (value < 0) return;
            _balance = value;
        }
    }

    public DateTime CreateDate
    {
        get { return _createDate; }
    }

    public BankAccount()
    {
        _createDate = DateTime.Now;
        _balance = 0;
    }

} 