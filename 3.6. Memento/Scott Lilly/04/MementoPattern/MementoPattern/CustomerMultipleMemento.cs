using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class CustomerMultipleMemento
    {
        // This is the memento object, which hold the original values.
        private readonly List<CustomerMemento> _customerMementoes = new List<CustomerMemento>();

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }

        //// Using the memento, to detect if the object has any changes.
        //public bool IsDirty
        //{
        //    get
        //    {
        //        return
        //            (Name != _customerMemento.Name) ||
        //            (Address != _customerMemento.Address) ||
        //            (City != _customerMemento.City) ||
        //            (StateProvince != _customerMemento.StateProvince) ||
        //            (PostalCode != _customerMemento.PostalCode);
        //    }
        //}

        public CustomerMultipleMemento(
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
            SaveMemento();
        }

        public void RevertToOriginalValues()
        {
            // Get the first memento, if there is one (there always should be at least one).
            CustomerMemento firstMemento = _customerMementoes.FirstOrDefault();
            // Check for null, just to be safe.
            if (null != firstMemento)
            {
                SetPropertyValuesFromMemento(firstMemento);
                // Remove all mementoes except the first one
                if (_customerMementoes.Count > 1)
                    _customerMementoes.RemoveRange(1, _customerMementoes.Count - 1);
            }
        }

        public void RevertToLastValues()
        {
            // Get the last memento, if there is one (there always should be at least one).
            CustomerMemento lastMemento = _customerMementoes.LastOrDefault();
            // Check for null, just to be safe.
            if (null != lastMemento)
            {
                SetPropertyValuesFromMemento(lastMemento);
                // Remove last memento except the first one
                if (_customerMementoes.First() != lastMemento)
                    _customerMementoes.Remove(lastMemento);
            }
        }

        private void SaveMemento()
        {
            _customerMementoes.Add(
                new CustomerMemento(
                    Name,
                    Address,
                    City,
                    StateProvince,
                    PostalCode));
        }
        private void SetPropertyValuesFromMemento(CustomerMemento lastMemento)
        {
            Name = lastMemento.Name;
            Address = lastMemento.Address;
            City = lastMemento.City;
            StateProvince = lastMemento.StateProvince;
            PostalCode = lastMemento.PostalCode;
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
