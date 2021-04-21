using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRider
{
    class Program
    {
        static void Main(string[] args) 
        {
            var fant = new DeskFan(new PowerSupply());
            Console.WriteLine(fant.Work());
        }

    }

    interface IPowerSupply
    {
        int GetPower();
    }


    class PowerSupply:IPowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }
    class DeskFan
    {
        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power <= 0)
            {
                return "won't work";
            }
            else if (power < 100)
            {
                return "slow";
            }
            else if (power < 200)
            {
                return "Work fine";
            }
            else
            {
                return "Warning";
            }

        }

    }





    }
