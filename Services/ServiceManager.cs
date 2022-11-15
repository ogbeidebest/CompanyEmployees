using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ServiceManager: IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyServices;
        private readonly Lazy<IEmployeeService> _employeesServices;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _companyServices = new Lazy<ICompanyService>(() => new
                CompanyService(repositoryManager, logger));
            _employeesServices = new Lazy<IEmployeeService>(() => new
            EmployeeService(repositoryManager, logger));

        }
        public ICompanyService CompanyService => _companyServices.Value;
        public IEmployeeService EmployeeService => _employeesServices.Value;
    }
}
