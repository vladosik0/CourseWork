using System;
namespace ShopNet
{
  public  class Product:Base<Product>
    {
        public double Price { get; set; }
        public string Name { get; private set; }
        public bool isBuyed { get; set; }
        public Product(Guid ID,double price,string name):base(ID)
        {
            isBuyed = false;
            Price = price;
            Name = name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return ID.Equals(((Product)obj).ID);
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
