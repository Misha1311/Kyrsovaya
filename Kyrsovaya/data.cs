using System;
using System.Collections.Generic;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Kyrsovaya
{
    [Serializable]
    class data
    {
        private string nameShop;
        private string address;
        private double code;
        private string productName;
        private double quantity;
        private double price;
        private double sum;
        private double min;

        public data()
        {

        }

        public string NameShop { get => nameShop; set => nameShop = value; }
        public string Address { get => address; set => address = value; }
        public double Code { get => code; set => code = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public double Sum { get => sum; set => sum = value; }
        public double Min { get => min; set => min = value; }

        public string Serialize()
        {
            return JsonSerializer.Serialize(dateb.newData);
        }

        public void Deserialize(string json)
        {
            dateb.newData = JsonSerializer.Deserialize<List<data>>(json);
        }
    };
}

