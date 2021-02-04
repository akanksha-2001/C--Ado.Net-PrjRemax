using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjRemax__Akanksha_2014178
{
    public class clsListClient
    {
        private Dictionary<String, clsClient> myClientList;

        public clsListClient()
        {
            myClientList = new Dictionary<string, clsClient>();
        }

        public int Quantity
        {
            get { return myClientList.Count; }

        }

        public Dictionary<string, clsClient>.ValueCollection Elements
        {
            get { return myClientList.Values; }

        }

        public bool Add(clsClient  client)
        {
            if (Exist(client.MyClient.Id) == false)
            {
                myClientList.Add(client.MyClient.Id, client);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string clientId)
        {
            if (Exist(clientId) == true)
            {
                myClientList.Remove(clientId);
                return true;
            }
            else
            {
                return false;
            }
        }


        public clsClient Update(string stringId, clsClient client)
        {
            return myClientList[stringId] = client;
        }

        public clsClient Find(string clientId)
        {
            if (Exist(clientId) == true)
            {
                return myClientList[clientId];
            }
            else
            {
                return null;
            }
        }

        public bool Exist(string clientId)
        {
            return myClientList.ContainsKey(clientId);

        }

        public string Display()
        {
            string info = "";
            foreach (clsClient client in myClientList.Values)
            {
                info = client.Display() + "\n===============================\n";
            }
            return info;
        }
    }
}