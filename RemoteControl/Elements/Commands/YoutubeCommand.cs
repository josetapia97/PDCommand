using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControl.Elements.Commands
{
    public class YoutubeCommand : ICommandCR
    {
        private ButtonPressed _bp;
        public YoutubeCommand(ButtonPressed bp)
        {
            _bp = bp;
        }
        public void Execute()
        {
            _bp.Youtube();
        }
    }
}
