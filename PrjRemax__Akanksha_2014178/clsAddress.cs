using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PrjRemax__Akanksha_2014178
{
    
    public class clsAddress
    {
        private String vAptNo;
        private string vStreetAddress;
        private string vCity;
        private string vProvince;
        private string vPostalCode;

        public clsAddress()
        {
            vAptNo = vStreetAddress = vCity = vPostalCode = vProvince = "Not Defined";
        }

        public clsAddress(string aptNo, string city, string province, string streetAddress, string postalCode)
        {
            vAptNo = aptNo;
            vCity = city;
            vProvince = province;
            vStreetAddress = streetAddress;
            vPostalCode = postalCode;
        }

        public string AptNo
        {
            get
            {
                return vAptNo;
            }
            set
            {
                this.vAptNo = AptNo;
            }
        }

        public string City
        {
            get { return vCity; }
            set
            {
                vCity = value;
            }
        }

        public string Province
        {
            get { return vProvince; }
            set
            {
                vProvince = value;
            }
        }

        public string StreetAddress
        {
            get { return vStreetAddress; }
            set
            {
                vStreetAddress = value;
            }
        }

        public string PostalCode
        {
            get { return vPostalCode; }
            set
            {
               
                    vPostalCode = value;
              
            }
        }

        public string Display()
        {
            string info = vAptNo + ", " + vStreetAddress + ", " + vCity + ", " + vProvince + ", " + vPostalCode;
            return info;
        }
    }
}