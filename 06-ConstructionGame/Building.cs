using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ConstructionGame
{
    public class Building : IBuilding
    {
        private List<string> _rooms;
        private string _describtion = "";
        public Building()
        {
            _rooms = new List<string>();
        }
        public IBuilding AddBalcony()
        {
            _rooms.Add("balcony");
            return this;
        }

        public IBuilding AddBedroom(string roomName)
        {
            _rooms.Add($"{roomName} room");
            return this;
        }

        public IBuilding AddBedroom()
        {
            throw new NotImplementedException();
        }

        public IBuilding AddKitchen()
        {
            _rooms.Add("kitchen");
            return this;
        }

        public IBuilding Build()
        {
            _describtion = string.Join(", ", _rooms);
            return this;
        }

        public string Describe()
        {
            return _describtion;
        }
    }
}
