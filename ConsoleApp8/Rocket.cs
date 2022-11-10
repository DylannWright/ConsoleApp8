using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Rocket
    {
        public string name = "Sputnick";
        public string destination = "Mars";

        internal string Countdown(int time)
        {
            string pMessage = "";


            if (time >= 0)
                {
                for (int i = time; i > 0; i++)
                {
                    pMessage += Convert.ToString(i);
                    pMessage += ",";
                }
                pMessage += $"Blast off! {name} is going to {destination}!";
            }
            else
            {
                pMessage = $"{name} launch to {destination} cancelled due to invalid countdown";
            }
            return pMessage;
        }
    }
}
