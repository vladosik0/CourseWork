using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace ShopNet
{
    public class Buying : Base<Buying>
    {
        public List<Product> ListOfProducts { get; private set; }
        public double PriceOfBuying { get; set; }
        public Guid _clientID { get; private set; }

        [JsonIgnore]
        public Client Client
        {
            get { return Client.Items[_clientID]; }
            set { _clientID = value.ID; }
        }
        //Конструктор створення об'єкта в програмі
        public Buying(Guid ID,List<Product> ListOfProducts):base(ID)
        {
            this.ListOfProducts = new List<Product>();
            foreach (var product in ListOfProducts)
            {
                this.ListOfProducts.Add(product);
                PriceOfBuying += product.Price;
            }
        }
        //Конструктор створення об'єкта при зчитуванні з JSON
        [JsonConstructor]
        public Buying(Guid ID, List<Product> ListOfProducts,Guid _clientID) : base(ID)
        {
            this.ListOfProducts = new List<Product>();
            foreach (var product in ListOfProducts)
            {
                this.ListOfProducts.Add(product);
                PriceOfBuying += product.Price;
            }
            this._clientID = _clientID;
        }
    }
}
