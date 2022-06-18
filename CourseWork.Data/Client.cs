using System;
using Newtonsoft.Json;
namespace ShopNet
{
  public class Client : Base<Client>
    {
        public Buying Buying 
        {
            get { return Base<Buying>.Items[_buyingID]; }
            set { _buyingID = value.ID; }
         }
        public double Balance { get; set; }
        public Guid _buyingID { get; private set; }
        public Guid _salesmanID { get; private set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [JsonIgnore]
        public Salesman Salesman
        {
            get { return Salesman.Items[_salesmanID]; }
            set { _salesmanID = value.ID; }
        }
        //Конструктор створення об'єкта при зчитуванні з JSON
        [JsonConstructor]
        public Client(Guid ID, string firstName, string middleName, string lastName,double balance,Guid _buyingID,Guid _salesmanID) : base(ID)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Balance = balance;
            this._buyingID = _buyingID;
            this._salesmanID = _salesmanID;
        }
        //Конструктор створення об'єкта в програмі
        public Client(Guid ID, string firstName, string middleName, string lastName, double balance, Buying buying,Salesman salesman) : base(ID)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Balance = balance;
            Buying = buying;
            Salesman = salesman;

        }


    }
}
