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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Wyslij_Click(object sender, EventArgs e)
        {
            string host = TB_Adres.Text;
            int port = (int)NUD_Port.Value;
            IPEndPoint zdalnyIP = new IPEndPoint(IPAddress.Any, 0);
            try
            {
               
                UdpClient klient = new UdpClient(host, port);

                Byte[] dane = Encoding.ASCII.GetBytes(TB_Wiadomosc.Text);
                Console.WriteLine("wyslane dane: " + dane.Length);
                klient.Send(dane, dane.Length);
                LB_Hosty.Items.Add("Wysyłanie wiadomości do hosta: " + host + ": " + port);
                
                //if (TB_Wiadomosc.Text == "koniec")
                    klient.Close();
                //klient.Connect(host, port);
                //Byte[] odczyt = klient.Receive(ref zdalnyIP);
                //string daneOdebrane = Encoding.ASCII.GetString(odczyt);
                //LB_Odebrane.Items.Add(daneOdebrane);
                //klient.Close();


            }

            catch (Exception ex) {

                LB_Hosty.Items.Add("Błąd: Nie udało się wysłać wiadomości!");
                MessageBox.Show(ex.ToString(), "Błąd");

            }

        }
    }
}
