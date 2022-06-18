using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
namespace ShopNet
{
   public class Salesman : Base<Salesman>
    {
        public List<int> Rates { get; private set; }
        private double rate=0;
        public Guid _shopID { get;  set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        [JsonIgnore]
        public Shop Shop
        {
            get { return Base<Shop>.Items[_shopID]; }
            set {_shopID=value.ID; }
        }
        public List<Client> ListOfClients
        {
            get
            {
                return Client.Items.Values.Where(c=>c.Salesman==this).ToList();
            }

        }
        public double Rate
        {
            get
            {
                rate = 0;
                if (Rates.Count == 0)
                {
                    return 0;
                }
                foreach (var tempRate in Rates)
                {
                    rate += tempRate;
                }
                return  rate / Rates.Count;
            }
        }
       //Конструктор створення об'єкта в програмі
        public Salesman(Guid ID, string firstName, string middleName, string lastName,decimal salary,Shop Shop) : base(ID)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Rates = new List<int>();
            Salary = salary;
            this.Shop = Shop;
        }
        //Конструктор створення об'єкта при зчитуванні з JSON
        [JsonConstructor]
        public Salesman(Guid ID, string firstName, string middleName, string lastName, decimal salary, Guid _shopID) : base(ID)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Rates = new List<int>();
            Salary = salary;
            this._shopID = _shopID;
        }
        //Метод для обслуговування клієнта
        public string ServeClient()
            {
            Random rand =new Random();
            string result = " ";
            switch(rand.Next(1,6))
            {
                case 1:
                    result ="Провалюйте звідси і ніколи не повертайтеся";
                    break;
                case 2:
                    result= "До побачення!";
                    break;
                case 3:
                    result= "Ваша покупка!!!";
                    break;
                case 4:
                    result = "Ваша покупка, будь ласка!";
                    break;
                case 5:
                    result= "Ваша покупка, гарного вам дня, приходьте ще!";
                    break;
            }
            return result;
            }
        public override string ToString()
        {
            return LastName+" "+FirstName+ " "+MiddleName;
        }
    }
}
