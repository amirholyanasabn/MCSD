using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookObjectDemo
{
    class Contact
    {
        private string name;
        private string family;
        private string phone;
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
        public void setPhone(string _phone)
        {
            if(_phone[0]!='0')
                _phone =$"021{_phone.Substring(1,_phone.Length-1)}";
            phone = _phone;
        }
        public string getPhone()
        {
            return phone;
        }
        public void setMobile(string _mobile)
        {
            if (_mobile.Substring(0,2)=="00")
            {
                _mobile = $"+{_mobile.Substring(2, _mobile.Length - 2)}";
            }
            else if (_mobile[0]=='0')
            {
                _mobile = $"+98{_mobile.Substring(1, _mobile.Length - 1)}";
            }

            mobile = _mobile;
         
        }
        public string getMobile()
        {
            return mobile;
        }
    }
}
