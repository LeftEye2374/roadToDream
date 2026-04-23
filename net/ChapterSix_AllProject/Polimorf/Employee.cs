namespace Employee;

partial class Employee
{
    private string _empName;
    private int _empId;
    private float _currPay;

    public Employee(string empName, int empId, float empPay)
    {
        _empName = empName;
        _empId = empId;
        _currPay = empPay;
    }

    public Employee() { }


    public string Name
    {
        get { return _empName; }
        set
        {
            if (value.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = value;
            }
        }
    }

    public int Id
    {
        get { return _empId; }
        set { _empId = value; }
    }

    public float Pay
    {
        get { return _currPay; }
        set { _currPay = value; }
    }
}