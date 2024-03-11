namespace MVCProject.Models
{
    public interface IEmpDataAccess
    {
        public List<Employee> GetEmps();
        public List<Employee> GetEmpsUsingSP();
        public Employee GetEmpById(int ecode);
        public void AddEmployee(Employee emp);
        public void UpdateEmployee(Employee emp);
        public void DeleteEmployee(int ecode);
        public void DeleteEmpUsingSP(int ecode);
    }
}
