using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class CustomerSimpleMemento
    {
        // These are the memento variables, which hold the original values.
        private readonly string _originalName;
        private readonly string _originalAddress;
        private readonly string _originalCity;
        private readonly string _originalStateProvince;
        private readonly string _originalPostalCode;

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
                    (Name != _originalName) ||
                    (Address != _originalAddress) ||
                    (City != _originalCity) ||
                    (StateProvince != _originalStateProvince) ||
                    (PostalCode != _originalPostalCode);
            }
        }

        public CustomerSimpleMemento(
            int id,
            string name,
            string address,
            string city,
            string stateProvince,
            string postalcode)
        {
            ID              = id;
            Name            = name;
            Address         = address;
            City            = city;
            StateProvince   = stateProvince;
            PostalCode      = postalcode;

            // Save the originally passed values to the "memento" variables.
            _originalName           = name;
            _originalAddress        = address;
            _originalCity           = city;
            _originalStateProvince  = stateProvince;
            _originalPostalCode     = postalcode;
        }

        public void RevertToOriginalValues()
        {
            Name            = _originalName;
            Address         = _originalAddress;
            City            = _originalCity;
            StateProvince   = _originalStateProvince;
            PostalCode      = _originalPostalCode;

        }
    }
}
