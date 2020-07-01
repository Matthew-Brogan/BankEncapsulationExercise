using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankEncapsulation
{
    class PersonalInformation
    {
        public PersonalInformation()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        private string _phoneNumber;

        public string NumberFormatted
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "($1)-$2-$3");
            }
        }



    }
}
