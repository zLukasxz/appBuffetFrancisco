using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.View
{
    public partial class TelaFecharVenda : Form
    {
        private int totalfinal;
        public TelaFecharVenda(int totalfinal)
        {
            InitializeComponent();
            this.totalfinal = totalfinal;
        }

        private void TelaFecharVenda_Load(object sender, EventArgs e)
        {

            lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_TotalFinal.Text = "R$" + totalfinal.ToString() + ",00";
        }
    }
}
