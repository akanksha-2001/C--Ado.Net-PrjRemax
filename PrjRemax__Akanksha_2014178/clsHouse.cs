using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjRemax__Akanksha_2014178
{
    public class clsHouse
    {
        private String vReferenceId;
        private clsAddress vAddress;
        private int vNoOfBathrooms;
        private int vNoOfBedrooms;
        private string vHouseType;
        private decimal vPrice;
        private string vStatus;
        private string vSellingType;

        public clsHouse(string refId, clsAddress address, int nbOfBath, int nbOfBeds, string houseType, decimal price, string sellingType, string status)
        {
            vReferenceId = refId;
            vAddress = new clsAddress();
            vNoOfBathrooms = nbOfBath;
            vNoOfBedrooms = nbOfBeds;
            vHouseType = houseType;
            vPrice = price;
            vStatus = status;
            vSellingType = sellingType;
        }

        public clsHouse()
        {
            vReferenceId = vHouseType = vSellingType = "Not Defined";
            vAddress = new clsAddress();
            vNoOfBathrooms = vNoOfBedrooms = 0;
            vPrice = 0;
            vStatus = "Sold";
        }

        public clsHouse(string referenceId,string aptNo,string streetAddress,string city,string province,string postalCode , int nbOfBath,int nbOfBeds, string houseType, decimal price, string sellingType, string status)
        {
            vReferenceId = referenceId;
            vAddress = new clsAddress(aptNo, city, province, streetAddress, postalCode);
            vNoOfBathrooms = nbOfBath;
            vNoOfBedrooms = nbOfBeds;
            vHouseType = houseType;
            vPrice = price;
            vStatus = status;
            vSellingType = sellingType;

        }

        public string ReferenceId
        {
            get { return vReferenceId; }
            
        }

        public clsAddress Address
        {
            get { return vAddress; }
            
        }

        public int NoOfBedrooms
        {
            get { return vNoOfBedrooms; }
            set
            {
                vNoOfBedrooms = NoOfBedrooms;
            }
        }

        public string HouseType
        {
            get { return vHouseType; }
            set
            {
                vHouseType = HouseType;
            }
        }

        public decimal Price
        {
            get { return vPrice = Price; }
            set
            {
                vPrice = Price;
            }
        }

        /// <summary>
        /// if is bought or rent or on sold
        /// </summary>
        public string Status
        {
            get { return vStatus = Status; }
            
        }

        /// <summary>
        /// if For buy or Sale or Rent
        /// </summary>
        public string SellingType
        {
            get
            { return vSellingType; }
            set
            {
                vSellingType = value;
            }
        }

        public int NoOfBathrooms
        {
            get { return NoOfBathrooms; }
            set
            {
                vNoOfBathrooms = NoOfBathrooms;
            }
        }

        public string Display()
        {
            string info = "ReferenceId : " + vReferenceId + "\nAddress : " + vAddress.Display() + "\nBedrooms : " + vNoOfBedrooms + "\nvBathrooms : " + vNoOfBathrooms + "\nHouseType : " + vHouseType + "\nPrice : " + vPrice + "Status : " + vStatus + "SellingType : " + vSellingType;
            return info;
        }
    }
}