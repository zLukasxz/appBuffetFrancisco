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
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            //Para fechar a aplicação
            Application.Exit();
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            //Tem variável do tipo texto que recebe da ferramenta text box
            string usuario = txb_Usuario.Text;
            string senha = txb_Senha.Text;

            //O algorítmo para verificar as credenciais e permitir o acesso
            if (usuario == "admin" && senha == "123")
            {
                //Vai fechar a tela de login e abrir a tela de menu
                this.Hide();
                //Instacia a tela de menu
                MenuTela Menu = new MenuTela();
                //A tela menu vai fechar com toda a aplicação, porém irá abrir a tela Manu novamente.
                Menu.FormClosed += (s, args) => this.Close();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Incorreta.");
            }
        }
    }
}
