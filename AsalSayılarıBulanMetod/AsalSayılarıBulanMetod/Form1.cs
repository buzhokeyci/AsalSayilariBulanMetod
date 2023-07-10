using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayılarıBulanMetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     void kacGUndurYasiyor2(DateTime dT)
        {
            TimeSpan aradaFark = DateTime.Now - dT;

        }
       
    void KacGundurYasiyor(DateTime dogumTarihi)
    {
        TimeSpan fark = DateTime.Now - dogumTarihi;
        MessageBox.Show(fark.TotalDays.ToString());
    }
}
}
