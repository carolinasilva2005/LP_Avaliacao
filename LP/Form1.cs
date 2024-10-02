using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPreco.Enabled = false;
            txtQuantidade.Enabled = false;
            txtQuantidade.Enabled = false;           
            txtValorAPagar.Enabled = false;
            textBox1.Enabled = true;
            xBox.Enabled = false;
            PlayStaion.Enabled = false;
            Wii.Enabled = false;
            NomeJogo.Enabled = false;
            textBox1.Enabled = false;
            // Para não ter acesso
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txtPreco.Enabled = true;
            txtQuantidade.Enabled = true;
            txtQuantidade.Enabled = true;
            xBox.Enabled = true;
            PlayStaion.Enabled = true;
            Wii.Enabled = true;
            NomeJogo.Enabled = true;
            // Depois do botão iniciar 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPreco.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtValorAPagar.Text = string.Empty;
            NomeJogo.Text = string.Empty;
            xBox.Checked = false;
            PlayStaion.Checked = false;
            Wii.Checked = false;
            textBox1.Text = string.Empty;
            // Para limpar todos os campos

        }
        
        private void btnCaulcular_Click(object sender, EventArgs e)
        {
            int resultado;
            txtValorAPagar.Text = (float.Parse(txtPreco.Text) * float.Parse(txtQuantidade.Text)).ToString();
            // Para fazer as contas 

            if (checkBox1.Checked)
            {
                
            }
        }


        private void Categorias_Enter(object sender, EventArgs e)
        {

        }

        private void xBox_CheckedChanged(object sender, EventArgs e)
        {
            if (xBox.Checked)
            {
                textBox1.Text = xBox.Text;
            }
        }

        private void PlayStaion_CheckedChanged(object sender, EventArgs e)
        {
            if (PlayStaion.Checked)
            {
                textBox1.Text = PlayStaion.Text;
            }
        }

        private void Wii_CheckedChanged(object sender, EventArgs e)
        {
            if (Wii.Checked)
            {
                textBox1.Text = Wii.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtValorAPagar.Text = (float.Parse(txtPreco.Text) * float.Parse(txtQuantidade.Text) * 0.90).ToString();
        }
    }
}
