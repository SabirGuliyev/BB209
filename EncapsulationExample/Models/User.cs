using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncapsulationExample.Models
{
    internal class User
    {
        public int FinCOde { get; set; }

        private string _name;
        private int _age;
        private string _userName;
        private string _password;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                
                value = value.Trim();
                if (value.Length >= 3)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ad formati yanlishdir");
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
           
        }

        public string Password
        {
            set
            {
                _password = value;
            }
        }

        public User(string name, string surname, string password)
        {
            Name = name;
            Surname = surname;
            _userName = string.Concat(name, ".", surname);
            Password = password;
        }













        public string Surname;

      

        //public void SetName(string name)
        //{
        //    name = name.Trim();
        //    if (name.Length >= 3)
        //    {
        //        Name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ad formati yanlishdir");
        //    }
        //}
        //public string GetName()
        //{
        //    return Name.ToUpper();
        //}

    }
}
