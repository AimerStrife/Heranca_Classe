using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetinho_Toguro
{
    public partial class Form1 : Form
    {
        Pessoa pess = new Pessoa(); // Instância do Objeto "pess"
        Funcionario func = new Funcionario(); // Instância do Objeto " func"
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Salvar 

            pess.setId(int.Parse(textBox1.Text));
            pess.setNome(textBox2.Text);
            pess.setDataNasc(dateTimePicker1.Value);
            MessageBox.Show("Os dados foram salvos com sucesso!", "Salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String mensagem = "identificador:" + pess.getId() +
                "\nNome: " + pess.getNome() +
                "\nData de Nascimento: " + pess.getDataNasc();
            MessageBox.Show(mensagem, "Exibir dados", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Salvar Funcionário 
            func.setId(int.Parse(textBox1.Text));
            func.setNome(textBox2.Text);
            func.setDataNasc(dateTimePicker2.Value);
            func.setDataAdm(dateTimePicker3.Value);
            MessageBox.Show("Os dados foram salvos com sucesso!", "Salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String mensagem = "identificador:" + func.getId() +
               "\nNome: " + func.getNome() +
               "\nData de Nascimento: " + func.getDataNasc()+
               "\nData de Admissão: " + func.getDatAdm();
            MessageBox.Show(mensagem, "Exibir dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
