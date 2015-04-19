namespace Poc.Deploy.FrontEndApp.Caching.Decorators
{
    using Poc.Deploy.FrontEndApp.DataAccess;

    public class EmployersOperationsCacheDecorator : IEmployersOperations
    {
        private readonly IEmployersOperations targetDecorated;

        private readonly ICacheStoreProxy cacheProxy;

        public EmployersOperationsCacheDecorator(IEmployersOperations targetDecorated, ICacheStoreProxy cacheProxy)
        {
            this.targetDecorated = targetDecorated;
            this.cacheProxy = cacheProxy;
        }

        public void HireEmployee(int employerId, string employeeName, int employeeSalary)
        {
            this.targetDecorated.HireEmployee(employerId, employeeName, employeeSalary);
            cacheProxy.InvalidateKey(employerId.ToString());
        }
    }
}