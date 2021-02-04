using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjRemax__Akanksha_2014178
{
    public class clsListHouses
    {
        private Dictionary<String, clsHouse> myHouseList;

        public clsListHouses()
        {
            myHouseList = new Dictionary<string, clsHouse>();
        }

        public int Quantity
        {
            get { return myHouseList.Count; }
            
        }

        public Dictionary<string,clsHouse>.ValueCollection Elements
        {
            get{ return myHouseList.Values; }
           
        }

        public bool Add(clsHouse house)
        {
            if (Exist(house.ReferenceId) == false)
            {
                myHouseList.Add(house.ReferenceId, house);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string refId)
        {
            if (Exist(refId) == true)
            {
                myHouseList.Remove(refId);
                return true;
            }
            else
            {
                return false;
            }
        }


        public clsHouse Update(string refId, clsHouse house)
        {
           return myHouseList[refId] = house;
        }

        public clsHouse Find(string refId)
        {
            if (Exist(refId) == true)
            {
                return myHouseList[refId];
            }
            else
            {
                return null;
            }
        }

        public bool Exist(string refId)
        {
            return myHouseList.ContainsKey(refId);
           
        }

        public string Display()
        {
            string info = "";
            foreach(clsHouse house in myHouseList.Values)
            {
                info = house.Display() + "\n===============================\n";
            }
            return info;
        }
    }
}