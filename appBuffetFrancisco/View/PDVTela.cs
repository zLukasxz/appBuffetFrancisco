using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.View
{
    public partial class PDVTela : Form
    {
        int totalfinal = 0;


        public PDVTela()
        {
            InitializeComponent();
        }

        private void btn_Coxinha_Click(object sender, EventArgs e)
        {
            string registroCoxinha = "0";
            txb_Codigo.Text = registroCoxinha;
        }

        private void btn_Kibe_Click(object sender, EventArgs e)
        {
            string registroKibe = "1";
            txb_Codigo.Text = registroKibe;
        }

        private void btn_Esfiha_Click(object sender, EventArgs e)
        {
            string registroEsfiha = "2";
            txb_Codigo.Text = registroEsfiha;
        }

        private void btn_BoloQueijo_Click(object sender, EventArgs e)
        {
            string registroBoloQueijo = "3";
            txb_Codigo.Text = registroBoloQueijo;
        }

        private void btn_Suco_Click(object sender, EventArgs e)
        {
            string registroSuco = "4";
            txb_Codigo.Text = registroSuco;
        }

        private void btn_Refrigerante_Click(object sender, EventArgs e)
        {
            string registroRefrigerante = "5";
            txb_Codigo.Text = registroRefrigerante;
        }

        private void btn_Cafe_Click(object sender, EventArgs e)
        {
            string registroCafe = "6";
            txb_Codigo.Text = registroCafe;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txb_Codigo.Text = "";
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txb_Codigo.Text);
            int qtd = ((int)nud_Qtd.Value);


            string[] itens = { "Coxinha", "Kibe", "Esfiha", "Bolinho de Queijo", "Sucos", "Refrigerante", "Café" };
            int[] array = { 8, 8, 8, 8, 12, 10, 15 };


            int total = qtd * array[codigo];

            totalfinal += total;

            dgv_PDV.Rows.Add(itens[codigo], qtd, array[codigo], total);
            lbl_Valor.Text = "R$" + totalfinal.ToString() + ",00";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            lbl_ValorTotal.Text = string.Empty;
            txb_Codigo.Text = string.Empty;
            nud_Qtd.Value = 0;
            dgv_PDV.Rows.Clear();
        }

        private void btn_Receber_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFecharVenda telaFecharVenda = new TelaFecharVenda(totalfinal);
            telaFecharVenda.FormClosed += (s, args) => this.Close();
            telaFecharVenda.Show();
        }
    }
}
