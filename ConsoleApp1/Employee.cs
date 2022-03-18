using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string _name;
        public string _surename;
        public  int _salary; 
        public string Name
        {
            get { return _name; }
            set
            {
               if(hasName(value)&&isdigit(value)&&toName(value))
                {
                    _name = value;  
                }
            }
        }
        public int Salary
        {
            get
            {
                return _salary; 
            }
            set
            {
                if (value > 250)
                {
                    _salary= value; 
                }
            }
        }
        static bool hasName (string  txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[0] == char.ToUpper(txt[0]))
                { 
                    return true;    
                }
            }
         return false;
        }
        static bool isdigit (string   txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (char.IsDigit(txt[i]))
                {
                    return false;
                }
            }
            return true;
        }
        static bool toName (string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[0]!=char.ToLower(txt[0]) && txt[i] == char.ToLower(txt[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
    
}
