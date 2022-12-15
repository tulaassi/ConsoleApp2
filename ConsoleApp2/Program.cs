using System;

internal class Date
{
    //Crarte 3 peoperties of type int and name them as Day ,Month,Year
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }



    //Create an Default constructor to assign default values for these properties



    public Date()
    {
        Day = 1;



        Month = 1;
        Year = 2022;
    }
    //Create an Parameterrized constructor to assign default values for these properties



    public Date(int d, int m, int y)
    {
        this.Day = d;
        this.Month = m;
        this.Year = y;
    }



    //to print the propertis of the Date class create 1.Method 2.tostring()



    public override string ToString()
    {
        return "" + Day + "/" + Month + "/" + Year;
    }



    //public void DiplayDate()
    //{
    //    Console.WriteLine(Day  +" /"  +Month + " / " + Year);
    //}
}



class DateMainCLass
{
    public static void Main()
    {
        Date obj = new Date(1, 1, 2022);
        //  obj.ToString();
        Console.WriteLine(obj);
        Console.ReadKey();
    }
}
public enum Department { HR, ACCOUNTS, PRODUCTION, PACKING, DISPATCH, SALES }
internal class Employee
{

    public int ID { get; set; }
    public String Name;
    public Department department;        //emp has to define date of joining using Date      
    public Date JoiningDt;
    public double Salary;
    public static int EmployeeCount = 0;
    // static value Member

    //emp has to define date of joining 

    //default constructor    
    public Employee()
    {
        ID = 0;
        Name = "";
        department = Department.HR;
        JoiningDt = new Date(10, 10, 2021);
        Salary = 0.0;
        EmployeeCount += 1;
    }
    //Parameterized constructor     
    public Employee(int id, String name, double salary, Date JoiningDt, Department department) { this.ID = id; this.Name = name; this.department = department; this.JoiningDt = JoiningDt; this.Salary = salary; EmployeeCount += 1; }
    public override string ToString() { return "\nEmployee Id = " + ID + "\nEmployee Name = " + Name + "\nDate of Joining = " + JoiningDt + "\nDepartment = " + department + "\nBasic Salary = " + Salary; }

    //Salary calculation  
    public virtual double CalculateSalary()
    {
        return Salary;
    }
}