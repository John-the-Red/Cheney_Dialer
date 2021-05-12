using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheney_Dialer
{
    class Phone
    {
        private string _company;
        private string _number;
        private int _type;

        public Phone(string Company, string Number, int Type)
        {
            _company = Company;
            _number = Number;
            _type = Type;
        }

        public void Dial()
        {
            if (_type == 1)
            {
                Console.WriteLine(_company + " is being dialed using "+ _number + "...");
            }
            else if(_type == 2)
            {
                Console.WriteLine(_company + " is being dialed using 1+" + _number + "...");
            }
        }
    }
}
