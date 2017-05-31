using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class CustomerBetterMemento
    {
        // This is the memento object, which hold the original values.
        private readonly CustomerMemento _customerMemento;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }

        // Using the memento, to detect if the object has any changes.
        public bool IsDirty
        {
            get
            {
                return
                    (Name != _customerMemento.Name) ||
                    (Address != _customerMemento.Address) ||
                    (City != _customerMemento.City) ||
                    (StateProvince != _customerMemento.StateProvince) ||
                    (PostalCode != _customerMemento.PostalCode);
            }
        }

        public CustomerBetterMemento(
            int id,
            string name,
            string address,
            string city,
            string stateProvince,
            string postalcode)
        {
            ID = id;
            Name = name;
            Address = address;
            City = city;
            StateProvince = stateProvince;
            PostalCode = postalcode;

            // Save the originally passed values to the "memento" variables.
            _customerMemento = new CustomerMemento(name, address, city, stateProvince, postalcode);
        }

        public void RevertToOriginalValues()
        {
            Name = _customerMemento.Name;
            Address = _customerMemento.Address;
            City = _customerMemento.City;
            StateProvince = _customerMemento.StateProvince;
            PostalCode = _customerMemento.PostalCode;

        }

        private class CustomerMemento
        {
            public string Name { get; private set; }
            public string Address { get; private set; }
            public string City { get; private set; }
            public string StateProvince { get; private set; }
            public string PostalCode { get; private set; }

            public CustomerMemento(string name, string address, string city, string stateProvince, string postalcode)
            {
                this.Name = name;
                this.Address = address;
                this.City = city;
                this.StateProvince = stateProvince;
                this.PostalCode = postalcode;
            }
        }

    }
}
