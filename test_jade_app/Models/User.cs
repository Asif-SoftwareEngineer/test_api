using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_jade_app.Models
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private Int16 _age;
        private string _address;
        private string _suburb;
        private string _state;
        private string _postcode;
        private string _country;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {

                _firstName = value; 
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {

                _lastName = value;
            }
        }

        public Int16 Age
        {
            get
            {
                return _age;
            }
            set
            {

                _age = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {

                _address = value;
            }
        }

        public string Suburb
        {
            get
            {
                return _suburb;
            }
            set
            {

                _suburb = value;
            }
        }
        public string State
        {
            get
            {
                return _state;
            }
            set
            {

                _state = value;
            }
        }


        public string PostCode
        {
            get
            {
                return _postcode;
            }
            set
            {

                _postcode = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {

                _country = value;
            }
        }


    }
}