using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Console_to_Gui
{
    public partial class Form1 : Form
    {
        private readonly SerialPort _serialPort;
        private readonly bool _continue;

        public Form1()
        {
            InitializeComponent();
            
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
         

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = "COM6";

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 5000;
            _serialPort.WriteTimeout = 5000;

            _serialPort.Open();
            _continue = true;
         

            //Console.WriteLine("Type QUIT to exit");

            

           
           
        }       
        private void button1_Click(object sender, EventArgs e)
        {
         
            string message;
            message = textBox1.Text;
            _serialPort.Write(message);
            

        }  
    }
}
