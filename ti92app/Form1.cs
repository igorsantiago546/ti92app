using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ti92class;

namespace ti92app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cliente clemte= new Cliente();

            //Nivel n = new Nivel();

            Nivel nivel = Nivel.ObterPorId(1);
            label1.Text = nivel.Id + " - " + nivel.Nome + " - " + nivel.Sigla;

            List<Nivel> list = Nivel.Listar();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Id + " - " + item.Nome);
            }
           
           
        }

        private void btnInsereNivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNivel.Text,txtSiglaNivel.Text);
            nivel.Inserir();
            txtIdNivel.Text = nivel.Id.ToString();
            List<Nivel> list = Nivel.Listar();
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.Id + " - " + item.Nome);
            }
            MessageBox.Show("Nível inserido com Sucesso \n ID: "+ nivel.Id.ToString());
            txtIdNivel.Clear();
            txtNomeNivel.Clear();
            txtSiglaNivel.Clear();
            txtNomeNivel.Focus();
           }
    
    }
}
