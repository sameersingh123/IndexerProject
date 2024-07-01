using System;
namespace IndexerProject
{
    class Employee
    {
        int EmpId;
        string Ename;
        string Location;
        double Salary;
        public string DName { get; set; }

        public Employee(int EmpId, string Ename, string Location, double Salary, string dName)
        {
            this.EmpId = EmpId;
            this.Ename = Ename;
            this.Location = Location;
            this.Salary = Salary;
            DName = dName;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return EmpId;
                }
                else if (index == 1)
                {
                    return Ename;
                }
                else if (index == 2)
                {
                    return Location;
                }
                else if (index == 3)
                {
                    return Salary;
                }
                else if (index == 4)
                {
                    return DName;
                }
                return null;
            }
            set
            {
                if (index == 0)
                {
                    EmpId = (int)value;
                }
                else if (index == 1)
                {
                    Ename = (string)value;
                }
                else if (index == 2)
                {
                    Location = (string)value;
                }
                else if (index == 3)
                {
                    Salary = (double)value;
                }
                else if (index == 4)
                {
                    DName = (string)value;
                }
            }
        }
    }
}

