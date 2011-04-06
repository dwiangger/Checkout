using System;
using System.Linq;
namespace Checkout.Models
{
    interface IStoreRepository
    {
        void Add(Department Department);
        void Add(Distributor Distributor);
        void Add(DistributorContact DistributorContact);
        void Add(Employee Employee);
        void Add(Product Product);
        void Delete(Department Department);
        void Delete(Distributor Distributor);
        void Delete(DistributorContact DistributorContact);
        void Delete(Employee Employee);
        void Delete(Product Product);
        IQueryable<DistributorContact> FindDistributorContact();
        DistributorContact FindDistributorContact(int Contact_ID);
        IQueryable<Department> FindDepartment();
        Department FindDepartment(int Department_ID);
        IQueryable<Distributor> FindDistributor();
        Distributor FindDistributor(int Distributor_ID);
        IQueryable<Employee> FindEmployee();
        Employee FindEmployee(int Employee_ID);
        IQueryable<Product> FindProduct();
        Product FindProduct(int Product_ID);
        void Save();
    }
}
