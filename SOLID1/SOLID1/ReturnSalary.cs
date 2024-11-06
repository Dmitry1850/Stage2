namespace SOLID1
{
    static class ReturnSalary
    {
        private const float NDFL = 13;

        public static float RealSalary(Employee employee)
        { 
            return (employee.GetSalary() - employee.GetSalary() * NDFL / 100);
        }
    }
}
