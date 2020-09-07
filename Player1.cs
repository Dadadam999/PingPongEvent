using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongEvent
{
   public class Player1
    {
        public delegate void PingHandler(string message);
        public event PingHandler PingEvent;

        public void Ping() {
            PingEvent?.Invoke("Ping recived pong\n");
        }
    }
}
