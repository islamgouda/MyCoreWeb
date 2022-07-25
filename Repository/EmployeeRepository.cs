using MyCoreWeb.Model;

namespace MyCoreWeb.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        Context con;
        public EmployeeRepository(Context _context)
        {
            con = _context;
        }
        public void delete(int id)
        {
            Employee employee=con.Employees.FirstOrDefault(e=> e.Id == id);
            con.Employees.Remove(employee);
            con.SaveChanges();
        }

        public List<Employee> getAll()
        {
            return con.Employees.ToList();
        }

        public Employee getById(int id)
        {
            return con.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void insert(Employee employee)
        {
            con.Employees.Add(employee);
            con.SaveChanges();
        }

        public void update(int id,Employee employee)
        {
            Employee emp = con.Employees.FirstOrDefault(e => e.Id == id);
            emp.Name=employee.Name;
            emp.Address=employee.Address;
            emp.Salary=employee.Salary;
            con.SaveChanges();
        }
    }
}
