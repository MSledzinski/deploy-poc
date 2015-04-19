namespace Poc.Deploy.FrontEndApp.DataAccess
{
    public interface IEmployersOperations
    {
        void HireEmployee(int employerId, string employeeName, int employeeSalary);
    }
}