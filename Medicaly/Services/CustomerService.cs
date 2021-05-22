﻿using Medicaly.Factories;
using Medicaly.Models;
using Medicaly.Password;
using Medicaly.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;


namespace Medicaly.Services
{
    public static class CustomerService
    {
        public static Customer login(Customer customer)
        {
            string email = customer.Email;
            string password = customer.Password;

            Customer csr = CustomerRepository.getCustomerByEmail(email);

            if (csr != null)
            {
                if (Hashing.Verify(password, csr.Password)) { return csr; }
                return null;
            }

            return csr;
        }

        public static bool addCustomer(Customer customer, string path)
        {
            if (CustomerRepository.getCustomerByEmail(customer.Email) != null)
            {
                return false;
            }

            string fileName = Path.GetFileNameWithoutExtension(customer.ImageUpload.FileName);
            string extension = Path.GetExtension(customer.ImageUpload.FileName);
            fileName = "csr_" + customer.Nama + "_" + fileName + extension;
            customer.FotoProfile = fileName;
            customer.ImageUpload.SaveAs(Path.Combine(path, fileName));

            customer.Password = Hashing.Hash(customer.Password);

            if (CustomerRepository.addCustomer(customer))
            {
                return true;
            }

            return false;
        }
    }
}