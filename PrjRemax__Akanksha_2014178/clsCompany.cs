using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjRemax__Akanksha_2014178
{
    public class clsCompany
    {
        private string vCmpId;
        private string vCmpLocation;
        private clsListEmployees vlistEmployees;
        private string vCmpEmail;
        private clsListClient vListClients;
        private clsListHouses vListHouses;

        public clsCompany(string cmpId, string cmpLocation, string cmpEmail, clsListEmployees listEmployees, string listClients, clsListHouses listHouses)
        {
            vCmpId = cmpId;
            vCmpEmail = cmpEmail;
            vCmpLocation = cmpLocation;
            vListClients = new clsListClient();
            vlistEmployees = new clsListEmployees();
            vListHouses = new clsListHouses();
        }

        public string CmpId
        {
            get { return vCmpId; }
            set
            {
            }
        }

        public string CmpLocation
        {
            get { return vCmpLocation; }
            set
            {
                vCmpLocation = value;
            }
        }

        public string CmpEmail
        {
            get { return vCmpEmail; }
            set
            {
                vCmpEmail = value;
            }
        }

        public clsListEmployees ListEmployees
        {
            get { return vlistEmployees; }
            set
            {
                vlistEmployees = value;
            }
        }

        public clsListClient ListClients
        {
            get { return vListClients; }
            set
            {
                vListClients = value;
            }
        }

        public clsListHouses ListHouses
        {
            get { return vListHouses; }
            set
            {
                vListHouses = value;
            }
        }
    }
}