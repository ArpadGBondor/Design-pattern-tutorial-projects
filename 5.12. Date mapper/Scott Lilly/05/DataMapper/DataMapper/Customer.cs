using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMapper
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsPremiumMember { get; set; }

        public Customer(int id, string name, bool isPremiumMember)
        {
            ID = id;
            Name = name;
            IsPremiumMember = isPremiumMember;
        }
    }
}
