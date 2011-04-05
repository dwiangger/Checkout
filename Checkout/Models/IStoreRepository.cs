using System;
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
        DistributorContact FindDistributorContact(int Contact_ID);
        Department FindDepartment(int Department_ID);
        Distributor FindDistributor(int Distributor_ID);
        Employee FindEmployee(int Employee_ID);
        Product FindProduct(int Product_ID);
        void Save();
    }
}
