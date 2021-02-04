using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjRemax__Akanksha_2014178
{
    public class clsClient
    {
        private clsUser vMyClient;
        private clsListHouses vListHouses;

        public clsClient()
        {
            vMyClient = new clsUser();
            vListHouses = new clsListHouses();
        }

        public clsClient(clsUser myClient, clsListHouses listHouses)
        {
            vMyClient = myClient;
            vListHouses = listHouses;
        }

        public clsClient(string clientId, string clientName, string clientPass, string location, string phoneNo)
        {
            vMyClient = new clsUser(clientName, clientPass, phoneNo
                , clientId, location);
        }

        public clsUser MyClient
        {
            get { return vMyClient; }
            set
            {
                vMyClient = value;
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

      

        
        public void Register(string clientId, string clientName, string clientPass, string location, string phoneNo)
        {
           vMyClient= new clsUser(clientName, clientPass, phoneNo
                , clientId, location);
        }

        public string Display()
        {
            
            string clientInfo = "Client : \n"+vMyClient.Display()+"\nHouse : "+vListHouses.Display();
            return clientInfo;
        }
    }
}