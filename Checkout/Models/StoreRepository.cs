﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkout.Models
{
    /// <summary>
    /// A data access layer for Store.sdf Use this instead of communicating directly with the StoreEntities class.
    /// </summary>
    class StoreRepository : Checkout.Models.IStoreRepository
    {
        public StoreRepository()
        {
            db = new StoreEntities();
        }
        StoreEntities db;

        /// <summary>
        /// Add a Product to the database.
        /// </summary>
        /// <param name="Product">The Product to be added</param>
        public void Add(Product Product)
        {
            db.Products.AddObject(Product);
        }
        /// <summary>
        /// Add a Deparment to the database.
        /// </summary>
        /// <param name="Product">The Department to be added</param>
        public void Add(Department Department)
        {
            db.Departments.AddObject(Department);
        }
        /// <summary>
        /// Add an Employee to the database.
        /// </summary>
        /// <param name="Product">The Employee to be added</param>
        public void Add(Employee Employee)
        {
            db.Employees.AddObject(Employee);
        }
        /// <summary>
        /// Add a Distributor to the database.
        /// </summary>
        /// <param name="Product">The Distributor to be added</param>
        public void Add(Distributor Distributor)
        {
            db.Distributors.AddObject(Distributor);
        }
        /// <summary>
        /// Add a DistributorContact to the database.
        /// </summary>
        /// <param name="Product">The DistributorContact to be added</param>
        public void Add(DistributorContact DistributorContact)
        {
            db.DistributorContacts.AddObject(DistributorContact);
        }

        /// <summary>
        /// Delete a Product from the database.
        /// </summary>
        /// <param name="Product">The Product to be deleted</param>
        public void Delete(Product Product)
        {
            db.Products.DeleteObject(Product);
        }
        /// <summary>
        /// Delete a Department from the database.
        /// </summary>
        /// <param name="Product">The Product to be deleted</param>
        public void Delete(Department Department)
        {
            db.Departments.DeleteObject(Department);
        }
        /// <summary>
        /// Delete a Employee from the database.
        /// </summary>
        /// <param name="Product">The Employee to be deleted</param>
        public void Delete(Employee Employee)
        {
            db.Employees.DeleteObject(Employee);
        }
        /// <summary>
        /// Delete a Distributor from the database.
        /// </summary>
        /// <param name="Product">The Distributor to be deleted</param>
        public void Delete(Distributor Distributor)
        {
            db.Distributors.DeleteObject(Distributor);
        }
        /// <summary>
        /// Delete a DistributorContact from the database.
        /// </summary>
        /// <param name="Product">The DistributorContact to be deleted</param>
        public void Delete(DistributorContact DistributorContact)
        {
            db.DistributorContacts.DeleteObject(DistributorContact);
        }

        /// <summary>
        /// Finds the product with the corresponding Product_ID. If no product is found, returns Null.
        /// </summary>
        /// <param name="Product_ID">The Product ID of a product in the database</param>
        /// <returns>Product, or if no product is found, returns Null.</returns>
        public Product FindProduct(int Product_ID)
        {
            return db.Products.FirstOrDefault(p => p.Product_ID == Product_ID);
        }
        /// <summary>
        /// Finds the product with the corresponding Department_ID. If no Department is found, returns Null.
        /// </summary>
        /// <param name="Department_ID">The Department ID of a product in the database</param>
        /// <returns>Department, or if no Department is found, returns Null.</returns>
        public Department FindDepartment(int Department_ID)
        {
            return db.Departments.FirstOrDefault(d => d.Department_ID == Department_ID);
        }
        /// <summary>
        /// Finds the Employee with the corresponding Employee_ID. If no Employee is found, returns Null.
        /// </summary>
        /// <param name="Employee_ID">The Employee ID of a product in the database</param>
        /// <returns>Employee, or if no Employee is found, returns Null.</returns>
        public Employee FindEmployee(int Employee_ID)
        {
            return db.Employees.FirstOrDefault(e => e.Employee_ID == Employee_ID);
        }
        /// <summary>
        /// Finds the Distributor with the corresponding Distributor_ID. If no Distributor is found, returns Null.
        /// </summary>
        /// <param name="Distributor_ID">The Distributor ID of a Distributor in the database</param>
        /// <returns>Distributor, or if no Distributor is found, returns Null.</returns>
        public Distributor FindDistributor(int Distributor_ID)
        {
            return db.Distributors.FirstOrDefault(d => d.Distributor_ID == Distributor_ID);
        }
        /// <summary>
        /// Finds the DistributorContact with the corresponding Contact_ID. If no DistributorContact is found, returns Null.
        /// </summary>
        /// <param name="Distributor_ID">The Contact ID of a DistributorContact in the database</param>
        /// <returns>DistributorContact, or if no DistributorContact is found, returns Null.</returns>
        public DistributorContact FindDistributorContact(int Contact_ID)
        {
            return db.DistributorContacts.FirstOrDefault(dc => dc.Contact_ID == Contact_ID);
        }

        /// <summary>
        /// Saves and commits all changes to the database.
        /// </summary>
        public void Save()
        {
            db.SaveChanges();
        }
    }
}