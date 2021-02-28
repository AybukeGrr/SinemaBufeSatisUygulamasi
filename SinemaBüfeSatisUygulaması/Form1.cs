using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBüfeSatisUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, Tambilet, su, cay, toplam, kahve, meyveSuyu, sogukCay, cocukBilet, ogrenciBilet, sicakCikolata;
            misir = Convert.ToInt16(TxtMisir.Text);
            Tambilet = Convert.ToInt16(TxtTamBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            kahve = Convert.ToInt16(TxtKahve.Text);
            meyveSuyu = Convert.ToInt16(TxtMeyve.Text);
            sogukCay = Convert.ToInt16(TxtSoguk.Text);
            cocukBilet = Convert.ToInt16(TxtCocukBilet.Text);
            ogrenciBilet = Convert.ToInt16(TxtÖgrenciBilet.Text);
            sicakCikolata = Convert.ToInt16(TxtCikolata.Text);

            toplam = misir * 4 + su*1 + cay*2 + Tambilet*15 + ogrenciBilet*10 + cocukBilet*6 + kahve*6 + meyveSuyu*3 + sogukCay*3 + sicakCikolata*83  ;
            LblToplam.Text = toplam.ToString() + " TL ";

            kasaTutar = kasaTutar + toplam;
            LblKasa.Text = kasaTutar.ToString() + " TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtCay.Text = ""; 
            TxtSu.Text = ""; 
            TxtMisir.Text = "";
            TxtCikolata.Text = "";
            TxtMeyve.Text = ""; 
            TxtTamBilet.Text = "";
            TxtÖgrenciBilet.Text = "";
            TxtCocukBilet.Text = "";
            TxtKahve.Text = "";
            TxtCikolata.Text = "";
            TxtSoguk.Text = "";

            TxtMisir.Focus();
        }

       
    }
}
