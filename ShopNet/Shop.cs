using System;
using System.Collections.Generic;
using System.Linq;
namespace ShopNet
{
    
    public class Shop:Base<Shop>
    {
        public string Address { get; set; }
        public double Square { get; set; }
        public int MaxSalesmenNumber { get; set; }
        
        public static List<Shop> ListOfShops
        {
            get
            {
                return Items.Values.ToList();
            }
        }
       public static Dictionary<Guid,Product> ListOfProducts
        {
            get 
            {
                Dictionary<Guid,Product> result = new Dictionary<Guid,Product>();
                foreach (var item in Base<Product>.Items.Values)
                {
                    if (!item.IsBuyed)
                    {
                        result.Add(item.ID,item);
                    }
                }
                return result;
                ;
            }
        }
       public List<Salesman> ListOfSalesmen
        {
            get 
            {
                List<Salesman> result = new List<Salesman>();
                foreach (var item in Salesman.Items.Values)
                {
                    if ( item.Shop == this)
                    {
                        result.Add(item);
                    }

                }
                return result;
               
            }   
        }

         public Shop(Guid ID,string address, double square, int maxSalesmenNumber):base(ID)
         {
            Address = address;
             Square = square;
             MaxSalesmenNumber = maxSalesmenNumber;
         }
        //Метод для звільнення  продавця
        public void FireSalesman(Salesman salesman)
        {
            foreach(var client in salesman.ListOfClients)
            {
                Client.Items.Remove(client.ID);
            }
            Salesman.Items.Remove(salesman.ID);
        }
        //Метод для відкриття магазину
        public static void OpenNewShop(string address,double square,int maxSalesmenNumber)
        {
            Shop shop = new Shop(Guid.NewGuid(),address,square,maxSalesmenNumber);
        }
        //Метод для зміни зарплати продавця
        public void ChangeSalary(int index,decimal newSalary)
        {
            ListOfSalesmen[index].Salary = newSalary;
        }
        //Метод для закриття магазину
        public static void CloseShop(Shop shop)
        {
            foreach(var salesman in shop.ListOfSalesmen)
            {
                foreach(var client in salesman.ListOfClients)
                {
                    Client.Items.Remove(client.ID);
                }
                Salesman.Items.Remove(salesman.ID);
            }
            Items.Remove(shop.ID);
            if (ListOfShops.Count == 0)
            {
                   Product.Items.Clear();
            }

        }
        public override string ToString()
        {
            return Address+ ", "+Square+" м^2";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return Address.GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return Address.GetHashCode();
        }
    }
}
