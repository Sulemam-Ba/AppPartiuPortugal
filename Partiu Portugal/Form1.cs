using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partiu_Portugal
{
    public partial class PartiuPt : Form
    {
        public PartiuPt()
        {
            InitializeComponent();
        }

        //BOTÃO VERIFICA OS CHECKBOXS
        private void Verificar_Click(object sender, EventArgs e)
        {
            //DELARAÇÃO DE VARIÁVEIS, ADICIONANDO OS VALORES DAS CHECKBOX
          bool passaporte = checkBox1.Enabled, passagens = checkBox2.Enabled, hospedagens = checkBox3.Enabled, seguro = checkBox4.Enabled, possuivalor =checkBox5.Enabled;
           





            //ESTRUTURA CONDICIONAL PARA SABER SE O USUÁRIO ESTA HABILITADO PARA VIAJAR
            if (passaporte == checkBox1.Checked && passagens == checkBox2.Checked && hospedagens == checkBox3.Checked && seguro == checkBox4.Checked && possuivalor == checkBox5.Checked)

   
            {
                MessageBox.Show("Pode viajar");
            }

            else
            {
                MessageBox.Show("Não Pode viajar");
            }

            //LIMPAR OS CAMPOS
            //checkBox1.Clear();
            //checkBox2.Clear();
            //checkBox3.Clear();
            //checkBox4.Clear();
            //checkBox5.Clear();
            

        }
        //BOTÃO CALCULAR VALORES PARA VIAJAR
        private void CALCULAR_Click(object sender, EventArgs e)
        {
            //DECLARAÇÃO DE VARIÁVEIS
            double dia = 0, valordia = 40, calculo = 0, mostrar = 0;

            //CONVERSÃO DA CAIXA DE TEXTO PARA DOUBLE
            dia = double.Parse(textBox1.Text);

            //CALCULO DIA X VALOR DIA
            calculo = (dia - 1) * valordia + 70;

            //CONVERSÃO PARA STRING
            MOSTRAVALOR.Text = Convert.ToString(calculo);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox6.Checked = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                checkBox1.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                checkBox7.Checked = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
                checkBox2.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                checkBox8.Checked = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
                checkBox3.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                checkBox9.Checked = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
                checkBox4.Checked = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                checkBox10.Checked = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
                checkBox5.Checked = false;
        }
    }
}

