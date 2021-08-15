using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_livraria
{
    public partial class Form1 : Form
    {

        string livro, genero, desc_exibe, gen_exibe;
        string excluir_livro, excluir_genero, atualizar_livro, atualizar_genero;
        string livro_antigo, genero_antigo;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {


                lbl_livro.Visible = true;
                txt_livro.Visible = true;
                txt_livro.Enabled = true;
                lbl_genero.Visible = true;
                txt_genero.Visible = true;
                txt_genero.Enabled = true;
                btn_cadastrar.Visible = true;

            }
            catch { }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            livro = txt_livro.Text.ToUpper();
            genero = txt_genero.Text.ToUpper();
            Verificacao(livro, genero);
        
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            lbl_livro_consulta.Visible = true;
            lbl_genero_consulta.Visible = true;
            txt_livro_consulta.Visible = true;
            txt_genero_consulta.Visible = true;
            btn_consultar.Visible = true;
            btn_todos_livros.Visible = true;
        }

        private void btn_todos_livros_Click(object sender, EventArgs e)
        {
            todos_livros();
        }
        void todos_livros()
        {
            lbl_livro_exibe.Visible = true;
            lbl_genero_exibe.Visible = true;
            lB_livro.Visible = true;
            lB_genero.Visible = true;
            btn_editar.Visible = true;
            btnRemover.Visible = true;
            lB_livro.Items.Clear();
            lB_genero.Items.Clear();
            string query = "SELECT Descricao, Genero FROM tbl_livraria group by Descricao, Genero order by descricao asc ";

            MySqlConnection objcon = new MySqlConnection("server=sql10.freemysqlhosting.net;port=3306;database=sql10430610;User Id=sql10430610;password=lF1cXXFIDU; convert zero datetime=True");
            objcon.Open();

            MySqlCommand cmd = new MySqlCommand(query, objcon);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            MySqlDataReader rst = cmd.ExecuteReader();

            if (rst.HasRows)
            {
                while (rst.Read())
                {
                    lB_livro.Items.Add(rst[0].ToString());
                    lB_genero.Items.Add(rst[1].ToString());
                }
            }
            else
            {
                MessageBox.Show("Não há livros registrados!");
            }

            cmd.Connection.Close();

            objcon.Close();
            txt_livro_consulta.Clear();
            txt_genero_consulta.Clear();
            txt_livro_consulta.Focus();
        }

   

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lB_livro.SelectedIndex==-1)
            {
                MessageBox.Show("Selecione um livro da lista!");
            }
            else
            {
                txt_editar_livro.Text = lB_livro.SelectedItem.ToString();
                txt_editar_genero.Text = lB_genero.SelectedItem.ToString();
                txt_editar_livro.Visible = true;
                txt_editar_genero.Visible = true;
                lbl_livro_editar.Visible = true;
                lbl_genero_editar.Visible = true;
                btn_confirmar.Visible = true;
                txt_genero_novo.Visible = true;
                txt_livro_novo.Visible = true;
                lbl_livro_novo.Visible = true;
                lbl_genero_novo.Visible = true;
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            
            if (txt_livro_novo.Text == string.Empty || txt_genero_novo.Text == string.Empty)
            { MessageBox.Show("Preencha com nome e o genero para realizar a alteração!"); }
            else
            {
                atualizar_livro = txt_livro_novo.Text.ToUpper();
                atualizar_genero = txt_genero_novo.Text.ToUpper();
                livro_antigo = txt_editar_livro.Text;
                genero_antigo = txt_editar_genero.Text;
                MySqlConnection strConn = new MySqlConnection("server=sql10.freemysqlhosting.net;port=3306;database=sql10430610;User Id=sql10430610;password=lF1cXXFIDU; convert zero datetime=True");
                strConn.Open();
                string Sql_insert = "update tbl_livraria set descricao = '" + atualizar_livro + "', genero='" + atualizar_genero + "' where descricao='" + livro_antigo + "' and genero='" + genero_antigo + "';";
                MySqlCommand cmd = new MySqlCommand(Sql_insert, strConn);

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                strConn.Close();
                MessageBox.Show("O Livro: " + livro_antigo + " foi atualizado para o livro: " + atualizar_livro);
                todos_livros();
                txt_livro_novo.Clear();
                txt_genero_novo.Clear();
                txt_editar_genero.Clear();
                txt_editar_livro.Clear();
            }
            }

      

        private void lB_livro_SelectedIndexChanged(object sender, EventArgs e)
        {
        lB_genero.SelectedIndex = lB_livro.SelectedIndex ;
            txt_editar_livro.Text = lB_livro.SelectedItem.ToString();
            txt_editar_genero.Text = lB_genero.SelectedItem.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            
            if (lB_livro.SelectedIndex==-1)
            {
                MessageBox.Show("Selecione um livro da lista!");
            }
            else
            {
                excluir_livro = lB_livro.SelectedItem.ToString();
                excluir_genero = lB_genero.SelectedItem.ToString();

                MySqlConnection strConn = new MySqlConnection("server=sql10.freemysqlhosting.net;port=3306;database=sql10430610;User Id=sql10430610;password=lF1cXXFIDU; convert zero datetime=True");
                strConn.Open();
                string Sql_insert = "delete from tbl_livraria where descricao='" + excluir_livro + "' and genero='" + excluir_genero + "';";
                MySqlCommand cmd = new MySqlCommand(Sql_insert, strConn);

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                strConn.Close();
                MessageBox.Show("O Livro" + excluir_livro + " excluído com sucesso!");
                todos_livros();
            }
        }

        public static void Verificacao(object livro, object genero)
        {

            string verificar, livro2,genero2;
            livro2 = livro.ToString();
            genero2 = genero.ToString();
        
            {


                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=sql10.freemysqlhosting.net;port=3306;database=sql10430610;User Id=sql10430610;password=lF1cXXFIDU; convert zero datetime=True");
                    objcon.Open();

                    string sql = "SELECT Descricao FROM tbl_livraria where Descricao = '" + livro + "'  group by Descricao;";
                    MySqlCommand cmd = new MySqlCommand(sql, objcon);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    MySqlDataReader rst = cmd.ExecuteReader();

                    if (rst.HasRows)
                    {
                        while (rst.Read())
                            verificar = rst[0].ToString();
                        MessageBox.Show("O livro já esta cadastrado!");
                    }
                    else
                    {

                        insert_livro(livro2, genero2);
                    }


                    cmd.Connection.Close();

                    objcon.Close();


                }
                catch
                {
                }
                MySqlConnection.ClearAllPools();
            }


        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            lbl_livro_exibe.Visible = true;
            lbl_genero_exibe.Visible = true;
            lB_livro.Visible = true;
            lB_genero.Visible = true;
            btn_editar.Visible = true;
            btnRemover.Visible = true;
            lB_livro.Items.Clear();
            lB_genero.Items.Clear();

            if (txt_livro_consulta.Text is null || txt_genero_consulta.Text is null || txt_livro_consulta.Text==string.Empty||txt_genero_consulta.Text==string.Empty)
            {
                MessageBox.Show("Para consultar um livro em específico digite o nome do livro e o genêro!");
            }
            else
            {
                string desc, gen;
                desc = "Descricao = '" + txt_livro_consulta.Text.ToUpper() + "' ";
                gen = " and Genero = '" + txt_genero_consulta.Text.ToUpper() + "' ";
                string query = "SELECT Descricao, Genero FROM tbl_livraria where " + desc + gen;

                MySqlConnection objcon = new MySqlConnection("server=sql10.freemysqlhosting.net;port=3306;database=sql10430610;User Id=sql10430610;password=lF1cXXFIDU; convert zero datetime=True");
                objcon.Open();

                MySqlCommand cmd = new MySqlCommand(query, objcon);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                MySqlDataReader rst = cmd.ExecuteReader();

                if (rst.HasRows)
                {
                    while (rst.Read())
                        desc_exibe = rst[0].ToString();
                    gen_exibe = rst[1].ToString();
                    lB_livro.Items.Add(desc_exibe);
                    lB_genero.Items.Add(gen_exibe);
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!");
                }

                cmd.Connection.Close();

                objcon.Close();
                txt_livro_consulta.Clear();
                txt_genero_consulta.Clear();
                txt_livro_consulta.Focus();

            }
        }

    

        static void insert_livro(object livro2, object genero2)
        {
            {
               
                MySqlConnection strConn = new MySqlConnection("server=sql10.freemysqlhosting.net;port=3306;database=sql10430610;User Id=sql10430610;password=lF1cXXFIDU; convert zero datetime=True");
                                               strConn.Open();
                string Sql_insert = "	INSERT INTO tbl_livraria (DESCRICAO, GENERO) VALUE ('" + livro2 + "', '" + genero2 + "'); ";

                MySqlCommand cmd = new MySqlCommand(Sql_insert, strConn);
                
                                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                strConn.Close();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }

        }

    }


}


