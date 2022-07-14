using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrxTesting
{
    public class Address : IReadOnlyAddress
    {
        public Address(string street1, string street2, string subCity, string city, string state, string subState,
            string zip, int country)
        {
            this.Street1 = street1;
            this.Street2 = street2;
            this.SubCity = subCity;
            this.City = city;
            this.State = state;
            this.SubState = subState;
            this.Zip = zip;
            this.CountryId = country;
        }

        public string City { get; }

        public int CountryId { get; }

        public string State { get; }

        public string StateDisplay { get; }

        public string StateFullDescription { get; }

        public string Street1 { get; }

        public string Street2 { get; }

        public string SubCity { get; }

        public string SubState { get; }

        public string Zip { get; }

        public string ZipNoClean { get; }
    }
}
