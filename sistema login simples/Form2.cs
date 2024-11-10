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
    public partial class Form2 : Form
    {

        public Form2(string usuario)
        {
            InitializeComponent();
            lblBoasVindas.Text = $"Bem vindo, {usuario}!";

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //por algumm motivo o this.Close() não está funcionando e fazendo o programa quebrar
            //this.Close();
            //e o Application.Exit() também não está funcionando e fazendo o programa quebrar kkkkk 
            //Application.Exit();

            //então eu fiz isso aqui
            Environment.Exit(0);

        }
    }
}
