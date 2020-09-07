using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongEvent
{
   public class Player2
    {
        public delegate void PongHandler(string message);
        public event PongHandler PongEvent;

        public void Pong()
        {
            PongEvent?.Invoke("Pong recived Ping\n");
        }
    }
}
