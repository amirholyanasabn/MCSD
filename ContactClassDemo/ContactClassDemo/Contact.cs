using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactClassDemo
{
    class Contact
    {
        private string name;
        private string family;
        private string phoneNumber;
        private string mobile;

        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }

        public void setFamily(string _family)
        {
            family = _family;
        }
        public string getFamily()
        {
            return family;
        }
        public void setPhoneNumber(string _phoneNumber)
        {
            if (!_phoneNumber.StartsWith("0"))
            {
                phoneNumber = "021" + _phoneNumber;
            }
            else
                phoneNumber = _phoneNumber;
        }
        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setMobile(string _cellPhone)
        {
            if (_cellPhone.Substring(0, 2) == "00")
                _cellPhone = $"+{_cellPhone.Substring(2, _cellPhone.Length - 2)}";
            else if (_cellPhone[0] == '0')
                _cellPhone = $"+98{_cellPhone.Substring(1, _cellPhone.Length - 1)}";

            mobile = _cellPhone;
        }
        public string getMobile()
        {
            return mobile;
        }
    }
}
