using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongEvent
{
    public partial class Main : Form
    {
        Player1 _p1;
        Player2 _p2;
        int _break = 5;
        public Main()
        {
            InitializeComponent();
            _p1 = new Player1();
            _p2 = new Player2();

            _p1.PingEvent += Ping_Listener;
            _p2.PongEvent += Pong_Listener;
        }


        private void Ping_Listener(string message) 
        {
            if (_break > 0)
            {
                cmd.Text = message;
                _break--;
                _p2.Pong();
                
            }

        }

        private void Pong_Listener(string message)
        {
            if (_break > 0)
            {
                cmd.Text = message;
                _break--;
                _p1.Ping();
               
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (_break > 0)
            {
                _break--;
                _p1.Ping();
            }
        }
    }
}
