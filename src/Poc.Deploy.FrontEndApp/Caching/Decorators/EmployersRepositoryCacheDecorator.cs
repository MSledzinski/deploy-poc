namespace Poc.Deploy.FrontEndApp.Caching.Decorators
{
    using Poc.Deploy.FrontEndApp.DataAccess;
    using Poc.Deploy.FrontEndApp.DataReadServices;

    public class EmployersRepositoryCacheDecorator : IEmployersRepository
    {
        private readonly IEmployersRepository decorationTarget;

        private readonly ICacheStoreProxy cacheProxy;

        public EmployersRepositoryCacheDecorator(IEmployersRepository decorationTarget, ICacheStoreProxy cacheProxy)
        {
            this.decorationTarget = decorationTarget;
            this.cacheProxy = cacheProxy;
        }

        public EmployerSummaryData GetEmployerSummary(int employerId)
        {
            EmployerSummaryData data = null;

            if (cacheProxy.TryGetWithKey(employerId.ToString(), out data))
            {
                return data;
            }

            data = decorationTarget.GetEmployerSummary(employerId);

            // awful code :)
            if (data != null)
            {
                cacheProxy.SetWithKey(employerId.ToString(), data);
            }

            return data;
        }
    }
}