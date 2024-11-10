using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_login_simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Solução 1
            try
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("Preencha todos os campos");
                    return;
                }
                if (usuario == "admin" && senha == "admin")
                {
                    Form2 form2 = new Form2(usuario);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Solução 2
            /*Form2 form2 = new Form2(this);
            if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
            {
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }*/

        }
    }
}
