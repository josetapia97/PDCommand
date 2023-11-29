using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Elements
{
    public class RemmoteControl
    {
        public void TakeCommand(ICommandCR command)
        {
            command.Execute();
        }
    }
}
