using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Getters_Setters
{
    class Employees
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { if (string.IsNullOrEmpty(value))
                    throw new Exception("The Employee name is not valid.");
                name = value;
            }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { 
                    if (Id < 0)
                    throw new Exception("The Employee ID is not valid.");
            }
        }


    }
}
