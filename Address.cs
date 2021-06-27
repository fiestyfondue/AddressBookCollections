using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionAddressBook
{
    class Address
    {
        public string FirstName;
        public string LastName;
        public string address;
        public string City;
        public string State;
        public int Zip;
        public int PhoneNo;
        public string Email;

        public Address(string firstName,string lastName, string address,string city,String state, int zip, int phoneNo,string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.PhoneNo = phoneNo;
            this.Email = email;
        }
    }
}
