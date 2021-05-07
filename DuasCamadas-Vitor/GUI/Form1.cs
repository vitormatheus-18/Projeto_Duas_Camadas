using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using DAL;
using Modelos;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)

        
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Inserir(moedas: new Moedas(txtNomeDaMoeda.Text, txtTerritorio.Text, txtSimbolo.Text, txtCodigoISO.Text, txtUnidade.Text, decimal.Parse(txtValorReais.Text)));
                ListarMoedas();
                MessageBox.Show($"Moeda: {txtNomeDaMoeda.Text} inserida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
        

       /*
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Deletar(txtEmail.Text);
                ListarClientes();
                MessageBox.Show($"Cliente: {txtEmail.Text} excluido do sistema!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarMoedas();
        }

        private void ListarMoedas()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                gridMoedas.DataSource = null;
                gridMoedas.DataSource = rep.Listar();
                gridMoedas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeDaMoeda_Click(object sender, EventArgs e)
        {

        }
    }
}
