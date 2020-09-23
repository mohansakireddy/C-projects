using System;

namespace myproject
{
    public class TestEncapsulation1
    {
        private string EmployeeName;
        private int EmployeeId;
        private string CompanyName = "Tcs";
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name is not given");
                }
                this.EmployeeName = value;

            }
            get
            {
                return this.EmployeeName;

            }

        }
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id cant be neative");

                }
                this.EmployeeId = value;

            }
            get
            {
                return this.EmployeeId;
            }

        }
        public string Company
        {
            get
            {
                return this.CompanyName;
            }
        }
    }
    public class TestEncapsualtion2
    {
       public static void Main()
        {
                TestEncapsulation1 t1 = new TestEncapsulation1();
                t1.Name = "Mohan";
                t1.Id = 1752971;
            Console.WriteLine("EmpName={0},EmpId={1},CompanyName={2}", t1.Name, t1.Id, t1.Company);

        }
    }
}
