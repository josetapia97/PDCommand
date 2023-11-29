using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Elements
{
    public class ButtonPressed
    {
        public void Netflix()
        {
            Console.WriteLine("Changed on Netflix");
        }

        public void Youtube()
        {
            Console.WriteLine("Changed on Youtube");
        }
        public void SearchGoogle()
        {
            Console.WriteLine("Searching on google");
        }
        public void TVMode()
        {
            Console.WriteLine("Searching your favorite cannals");
        }
    }
}
