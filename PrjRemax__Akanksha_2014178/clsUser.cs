using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrjRemax__Akanksha_2014178
{
    public class clsUser
    {
        private String vName;
        private string vPass;
        private string vId;
        private string vPhoneNo;
        private string vLocation;

        public clsUser()
        {
            vName = vPass = vId = vPhoneNo = vLocation = "Not Defined";
        }

        public clsUser(string name, string pass, string phoneNo, string id, string location)
        {
            vName = name;
            vPass = pass;
            vId = id;
            vPhoneNo = phoneNo;
            vLocation = location;
        }

        public string Name
        {
            get
            {
                return vName;
            }
            set
            {
                vName = value;
            }
        }

        public string Pass
        {
            get { return vPass; }
            set
            {
                vPass = value;

                
            }
        }

        public string Id
        {
            get { return vId; }
            set
            {
                vId = value;
            }
        }

        public string PhoneNo
        {
            get { return vPhoneNo; }
            set
            {
             
                vPhoneNo = value;
            }
        }

        public string Location
        {
            get { return vLocation; }
            set
            {
                vLocation = value;
            }
        }

        public string Display()
        {
            string info = "Id : " + vId + "\nName :  " + vName + "\nPass " + vPass + "\nPhoneNo :  " + vPhoneNo + "\nLocation : " + vLocation;
            return info;
        }
    }

}
