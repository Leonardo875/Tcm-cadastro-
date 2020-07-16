using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class agendamento : Form
    {
        public agendamento()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro fm5 = new menu_cadastro();
            fm5.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta fm3 = new consulta();
            fm3.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pagamento mnpaga = new pagamento();
            mnpaga.Show();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if(textBox4.Text == "")
            {
                textBox4.Text = "Nº do Passaporte";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if(textBox4.Text == "Nº do Passaporte")
            {
                textBox4.Text = "";
            }
        }
    }
}
