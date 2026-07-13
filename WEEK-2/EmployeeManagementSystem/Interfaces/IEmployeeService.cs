public interface IEmployeeService
{
    void AddEmployee(Employee employee);

    void ViewEmployees();

    void SearchEmployee(int id);

    void UpdateEmployee(int id);

    void DeleteEmployee(int id);
}