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
            cmbNivelUser.DataSource = Nivel.Listar();
            cmbNivelUser.DisplayMember = "Nome";
            CarregaLista();


            Nivel nivel = Nivel.ObterPorId(1);

            AtualizaListBox();

        }

        private void btnInsereNivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNivel.Text, txtSiglaNivel.Text);
            nivel.Inserir();
            txtIdNivel.Text = nivel.Id.ToString();
            AtualizaListBox();
            MessageBox.Show("Nível inserido com Sucesso \n ID: " + nivel.Id.ToString());

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                txtIdNivel.ReadOnly = false;
                txtIdNivel.Focus();
                btnEditar.Text = "Gravar";
                btnInsereNivel.Enabled = false;
            }
            else
            {
                Nivel nivel = new Nivel();
                nivel.Id = int.Parse(txtIdNivel.Text);
                nivel.Nome = txtNomeNivel.Text;
                nivel.Sigla = txtSiglaNivel.Text;
                Nivel.Atualizar(nivel);
                txtIdNivel.ReadOnly = true;
                txtNomeNivel.Focus();
                btnEditar.Text = "Editar";
                AtualizaListBox();
            }
        }

        private void txtIdNivel_TextChanged(object sender, EventArgs e)
        {
            if (txtIdNivel.Text != string.Empty)
            {
                int id = int.Parse(txtIdNivel.Text);
                var nivel = Nivel.ObterPorId(id);
                txtNomeNivel.Text = nivel.Nome;
                txtSiglaNivel.Text = nivel.Sigla;
            }

        }
        private void AtualizaListBox()
        {
            List<Nivel> list = Nivel.Listar();
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add("ID: " + item.Id + " - " + item.Nome + " - " + item.Sigla);
                txtIdNivel.Clear();
                txtNomeNivel.Clear();
                txtSiglaNivel.Clear();
                txtNomeNivel.Focus();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            // se txtBusca.Text for diferente de vazio
            // e (&&) txtBusca.Text.Length for maior ou igual a 2 caracteres
            if (txtBusca.Text != string.Empty && txtBusca.Text.Length >= 2)
            {
                listBox1.Items.Clear();
                var niveis = Nivel.BuscarPorNome(txtBusca.Text);
                if (niveis.Count > 0)
                {
                    foreach (var nivel in niveis)
                    {
                        listBox1.Items.Add(nivel.Id + " - " + nivel.Nome + " - " + nivel.Sigla);
                    }

                }
                else
                {

                    listBox1.Items.Add("Não há registros para essa consulta...");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdNivel.Text != string.Empty)
            {
                Nivel nivel = Nivel.ObterPorId(int.Parse(txtIdNivel.Text));
                if (nivel.Excliur(nivel.Id))
                {
                    MessageBox.Show("Nível " + nivel.Nome + " excluido com sucesso!", "Exclusão de nível");
                    AtualizaListBox();
                }

            }
        }

        private void btnInserirUser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtNomeUser.Text, txtEmailUser.Text, txtSenhaUser.Text, Nivel.ObterPorId(Convert.ToInt32(cmbNivelUser.SelectedValue)), chkUser.Checked);
            usuario.Inserir();
            txtIdUser.Text = usuario.Id.ToString();
            CarregaLista();
        }
        private void CarregaLista()
        {
            lstListaUser.Items.Clear();
            var lista = Usuario.Listar();
            foreach (var item in lista)
            {
                lstListaUser.Items.Add(item.Id + " - " + item.Nome + " - " + item.Nivel.Nome);
            }
        }

        private void txtIdUser_TextChanged(object sender, EventArgs e)
        {
            
                if (txtIdUser.Text != string.Empty)
                {
                    int id = int.Parse(txtIdUser.Text);
                    var usuario = Usuario.ObterPorId(id);
                    txtNomeUser.Text = usuario.Nome;
                    txtEmailUser.Text = usuario.Email;
                    txtSenhaUser.Text = usuario.Senha;
                    cmbNivelUser.Text = Nivel.ObterPorId(id).ToString();
                    chkUser.Checked = usuario.Ativo;
            }

            
        }
    }
}
