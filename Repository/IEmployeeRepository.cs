using MyCoreWeb.Model;

namespace MyCoreWeb.Repository
{
    public interface IEmployeeRepository
    {
        public Employee getById(int id);

        public List<Employee> getAll();
        public void insert(Employee employee);
        public void update(int id, Employee employee);
        public void delete(int id);
    }
}
