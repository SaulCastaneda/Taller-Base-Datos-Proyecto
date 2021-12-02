using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suppliers
    {
        private string SupplierID;
        private string CompanyName;
        private string ContactName;
        private string ContactTitle;
        private string Address;
        private string City;
        private string Region;
        private string PostalCode;
        private string Country;
        private string Phone;
        private string Fax;
        private string HomePage;

        public Suppliers(string id, string company, string contact,string title, string address, string city, string region, string postal,
            string country, string phone, string fax, string home)
        {
            SupplierID = id;
            CompanyName = company;
            ContactName = contact;
            ContactTitle = title;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postal;
            Country = country;
            Phone = phone;
            Fax = fax;
            HomePage = home;
        }

        public string pSupplierID
        {
            get
            {
                return SupplierID;
            }
            set
            {
                SupplierID = value;
            }
        }
        public string pCompanyName
        {
            get
            {
                return CompanyName;
            }
            set
            {
                CompanyName = value;
            }
        }
        public string pContactName
        {
            get
            {
                return ContactName;
            }
            set
            {
                ContactName = value;
            }
        }
        public string pContactTitle
        {
            get
            {
                return ContactTitle;
            }
            set
            {
                ContactTitle = value;
            }
        }
        public string pAddress
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string pCity
        {
            get
            {
                return City;
            }
            set
            {
                City = value;
            }
        }
        public string pRegion
        {
            get
            {
                return Region;
            }
            set
            {
                Region = value;
            }
        }
        public string pPostalCode
        {
            get
            {
                return PostalCode;
            }
            set
            {
                PostalCode = value;
            }
        }
        public string pCountry
        {
            get
            {
                 return HomePage;
            }
            set
            {
                Country = value;
            }
        }
        public string pPhone
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        public string pFax
        {
            get
            {
                return Fax;
            }
            set
            {
                Fax = value;
            }
        }
        public string pHomePage
        {
            get
            {
                return HomePage;
            }
            set
            {
                HomePage = value;
            }
        }

    }
}
