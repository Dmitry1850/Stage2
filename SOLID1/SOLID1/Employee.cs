namespace SOLID1
{
    class Employee
    {
        public Employee(int id, string name, int salary) 
        { 
            _id = id;
            _name = name;
            _salary = salary;
        }

        private readonly int _id;
        private readonly int _salary;
        private readonly string _name;

        public int GetID()
        { 
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetSalary()
        {
            return _salary;
        }
    }
}
