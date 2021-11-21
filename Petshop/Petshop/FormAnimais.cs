using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Petshop
{
    public partial class FormAnimais : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Petshop\\Petshop\\DbPetshop.mdf;Integrated Security=True");

        public FormAnimais()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaDgv()
        {
            String sql = "SELECT * FROM Animais";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable teste = new DataTable();
            da.Fill(teste);
            dgvAnimais.DataSource = teste;
            con.Close();
        }

        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Inseriranimais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proprietario", SqlDbType.Int).Value = Convert.ToInt32(txtIDproprietario.Text.Trim());
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                cmd.Parameters.AddWithValue("@datanascimento", SqlDbType.Date).Value = Convert.ToDateTime(txtDatanascimento.Text.Trim());
                cmd.Parameters.AddWithValue("@especie", SqlDbType.NChar).Value = txtEspecie.Text;
                cmd.Parameters.AddWithValue("@pelagem", SqlDbType.NChar).Value = txtPelagem.Text;
                cmd.Parameters.AddWithValue("@peso", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPeso.Text.Trim());
                cmd.Parameters.AddWithValue("@porte", SqlDbType.NChar).Value = txtPorte.Text;
                cmd.Parameters.AddWithValue("@sexo", SqlDbType.NChar).Value = txtSexo.Text;
                cmd.Parameters.AddWithValue("@raca", SqlDbType.NChar).Value = txtRaca.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal inserido com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtIDproprietario.Text = "";
                txtNome.Text = "";
                txtDatanascimento.Text = "";
                txtEspecie.Text = "";
                txtPelagem.Text = "";
                txtPeso.Text = "";
                txtPorte.Text = "";
                txtSexo.Text = "";
                txtRaca.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AtualizarAnimais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIDanimal.Text.Trim());
                cmd.Parameters.AddWithValue("@id_proprietario", SqlDbType.Int).Value = Convert.ToInt32(txtIDproprietario.Text.Trim());
                cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text;
                cmd.Parameters.AddWithValue("@raca", SqlDbType.NChar).Value = txtRaca.Text;
                cmd.Parameters.AddWithValue("@datanascimento", SqlDbType.Date).Value = Convert.ToDateTime(txtDatanascimento.Text.Trim());
                cmd.Parameters.AddWithValue("@especie", SqlDbType.NChar).Value = txtEspecie.Text;
                cmd.Parameters.AddWithValue("@sexo", SqlDbType.NChar).Value = txtSexo.Text;
                cmd.Parameters.AddWithValue("@pelagem", SqlDbType.NChar).Value = txtPelagem.Text;
                cmd.Parameters.AddWithValue("@peso", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPeso.Text.Trim());
                cmd.Parameters.AddWithValue("@porte", SqlDbType.NChar).Value = txtPorte.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtIDanimal.Text = "";
                txtIDproprietario.Text = "";
                txtNome.Text = "";
                txtRaca.Text = "";
                txtDatanascimento.Text = "";
                txtEspecie.Text = "";
                txtSexo.Text = "";
                txtPelagem.Text = "";
                txtPeso.Text = "";
                txtPorte.Text = "";
                
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnApgar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ApagarAnimais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIDanimal.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Animal apagado com sucesso!", "Apagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                CarregaDgv();
                txtIDanimal.Text = "";
                txtIDproprietario.Text = "";
                txtNome.Text = "";
                txtDatanascimento.Text = "";
                txtEspecie.Text = "";
                txtPelagem.Text = "";
                txtPeso.Text = "";
                txtPorte.Text = "";
                txtSexo.Text = "";
                txtRaca.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LocalizarAnimais", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Convert.ToInt32(txtIDanimal.Text.Trim());
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIDproprietario.Text = dr["id_proprietarios"].ToString();
                    txtNome.Text = dr["nome"].ToString();
                    txtDatanascimento.Text = dr["datanascimento"].ToString();
                    txtEspecie.Text = dr["especie"].ToString();
                    txtPelagem.Text = dr["pelagem"].ToString();
                    txtPeso.Text = dr["peso"].ToString();
                    txtPorte.Text = dr["porte"].ToString();
                    txtSexo.Text = dr["sexo"].ToString();
                    txtRaca.Text = "";
                    dr.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum Animal localizado com este ID?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }


        }

        private void dgvAnimais_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAnimais.Rows[e.RowIndex];
                txtIDanimal.Text = row.Cells[0].Value.ToString();
                txtIDproprietario.Text = row.Cells[1].Value.ToString();
                txtNome.Text = row.Cells[2].Value.ToString();
                txtRaca.Text = row.Cells[3].Value.ToString();
                txtDatanascimento.Text = row.Cells[4].Value.ToString();
                txtEspecie.Text = row.Cells[5].Value.ToString();
                txtPelagem.Text = row.Cells[6].Value.ToString();
                txtPeso.Text = row.Cells[7].Value.ToString();
                txtPorte.Text = row.Cells[8].Value.ToString();
                txtSexo.Text = row.Cells[9].Value.ToString();
            }


        }

        private void FormAnimais_Load(object sender, EventArgs e)
        {
            CarregaDgv();
        }
    }
}
