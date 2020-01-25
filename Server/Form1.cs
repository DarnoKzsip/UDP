using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
 
            InitializeComponent();
            
        }

        private void BTN_Uruchom_Click(object sender, EventArgs e)
        {
           
            IPEndPoint zdalnyIP = new IPEndPoint(IPAddress.Any, 0);
            try
            {
                int port = (int)NUD_Port.Value;
                UdpClient serwer = new UdpClient(port);
                serwer.Client.ReceiveBufferSize = 4;
                Console.WriteLine("Dostepne dane: " + serwer.Available);
                Byte[] odczyt = serwer.Receive(ref zdalnyIP);
                string dane = Encoding.ASCII.GetString(odczyt);
                LB_KomunikatyOdebrane.Items.Add(dane);
                serwer.Close();
                serwer.Connect(zdalnyIP.Address, zdalnyIP.Port);
                Byte[] odpowiedz = Encoding.ASCII.GetBytes("Odebrałem paczke: " + odczyt.Length);
                serwer.Send(odpowiedz, odpowiedz.Length);
                //if (dane == "koniec")
                    serwer.Close();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Błąd");

            }
        }

       
    }
}
