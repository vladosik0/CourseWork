using System;
using System.Collections.Generic;

namespace ShopNet
{
    //Клас-аналог бази даних
   public class Base<T> where T:Base<T>
    {
        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();

        public Guid ID { get; private set; }
        public Base(Guid ID)
        {
            this.ID = ID;
            Items.Add(ID, (T)this);
        }
      
    }
}
