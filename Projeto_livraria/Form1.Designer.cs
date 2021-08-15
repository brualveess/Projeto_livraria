
namespace Projeto_livraria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_livro_exibe = new System.Windows.Forms.Label();
            this.lbl_genero_consulta = new System.Windows.Forms.Label();
            this.lblSenhaInvalida = new System.Windows.Forms.Label();
            this.txt_livro_consulta = new System.Windows.Forms.TextBox();
            this.lbl_livro_consulta = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_todos_livros = new System.Windows.Forms.Button();
            this.txt_genero_consulta = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.lbl_livro = new System.Windows.Forms.Label();
            this.txt_livro = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.lbl_cadastro_consulta = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.gb_cadastro = new System.Windows.Forms.GroupBox();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.tbllivrariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sql10430610DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sql10430610DataSet = new Projeto_livraria.sql10430610DataSet();
            this.tbl_livrariaTableAdapter = new Projeto_livraria.sql10430610DataSetTableAdapters.tbl_livrariaTableAdapter();
            this.lbl_genero_exibe = new System.Windows.Forms.Label();
            this.lB_livro = new System.Windows.Forms.ListBox();
            this.lB_genero = new System.Windows.Forms.ListBox();
            this.txt_editar_livro = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_editar_genero = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_genero_editar = new System.Windows.Forms.Label();
            this.lbl_livro_editar = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_genero_novo = new System.Windows.Forms.Label();
            this.lbl_livro_novo = new System.Windows.Forms.Label();
            this.txt_genero_novo = new System.Windows.Forms.TextBox();
            this.txt_livro_novo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gb_cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbllivrariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql10430610DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql10430610DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(140, 156);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(104, 23);
            this.btn_editar.TabIndex = 88;
            this.btn_editar.Text = "Editar Livro";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Visible = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_livro_exibe
            // 
            this.lbl_livro_exibe.AutoSize = true;
            this.lbl_livro_exibe.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_livro_exibe.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_livro_exibe.Location = new System.Drawing.Point(114, 16);
            this.lbl_livro_exibe.Name = "lbl_livro_exibe";
            this.lbl_livro_exibe.Size = new System.Drawing.Size(60, 22);
            this.lbl_livro_exibe.TabIndex = 85;
            this.lbl_livro_exibe.Text = "Livro:";
            this.lbl_livro_exibe.Visible = false;
            // 
            // lbl_genero_consulta
            // 
            this.lbl_genero_consulta.AutoSize = true;
            this.lbl_genero_consulta.Location = new System.Drawing.Point(267, 25);
            this.lbl_genero_consulta.Name = "lbl_genero_consulta";
            this.lbl_genero_consulta.Size = new System.Drawing.Size(45, 13);
            this.lbl_genero_consulta.TabIndex = 9;
            this.lbl_genero_consulta.Text = "Genêro:";
            this.lbl_genero_consulta.Visible = false;
            // 
            // lblSenhaInvalida
            // 
            this.lblSenhaInvalida.AutoSize = true;
            this.lblSenhaInvalida.Location = new System.Drawing.Point(644, 352);
            this.lblSenhaInvalida.Name = "lblSenhaInvalida";
            this.lblSenhaInvalida.Size = new System.Drawing.Size(0, 13);
            this.lblSenhaInvalida.TabIndex = 76;
            // 
            // txt_livro_consulta
            // 
            this.txt_livro_consulta.Location = new System.Drawing.Point(161, 22);
            this.txt_livro_consulta.Name = "txt_livro_consulta";
            this.txt_livro_consulta.Size = new System.Drawing.Size(100, 20);
            this.txt_livro_consulta.TabIndex = 8;
            this.txt_livro_consulta.Visible = false;
            // 
            // lbl_livro_consulta
            // 
            this.lbl_livro_consulta.AutoSize = true;
            this.lbl_livro_consulta.Location = new System.Drawing.Point(100, 25);
            this.lbl_livro_consulta.Name = "lbl_livro_consulta";
            this.lbl_livro_consulta.Size = new System.Drawing.Size(33, 13);
            this.lbl_livro_consulta.TabIndex = 7;
            this.lbl_livro_consulta.Text = "Livro:";
            this.lbl_livro_consulta.Visible = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(283, 156);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(111, 23);
            this.btnRemover.TabIndex = 75;
            this.btnRemover.Text = "Excluir Livro";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_todos_livros);
            this.groupBox1.Controls.Add(this.txt_genero_consulta);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.lbl_genero_consulta);
            this.groupBox1.Controls.Add(this.txt_livro_consulta);
            this.groupBox1.Controls.Add(this.lbl_livro_consulta);
            this.groupBox1.Location = new System.Drawing.Point(81, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 99);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Livro";
            // 
            // btn_todos_livros
            // 
            this.btn_todos_livros.Location = new System.Drawing.Point(283, 64);
            this.btn_todos_livros.Name = "btn_todos_livros";
            this.btn_todos_livros.Size = new System.Drawing.Size(154, 23);
            this.btn_todos_livros.TabIndex = 17;
            this.btn_todos_livros.Text = "Consultar TODOS os Livros";
            this.btn_todos_livros.UseVisualStyleBackColor = true;
            this.btn_todos_livros.Visible = false;
            this.btn_todos_livros.Click += new System.EventHandler(this.btn_todos_livros_Click);
            // 
            // txt_genero_consulta
            // 
            this.txt_genero_consulta.Location = new System.Drawing.Point(321, 18);
            this.txt_genero_consulta.Name = "txt_genero_consulta";
            this.txt_genero_consulta.Size = new System.Drawing.Size(100, 20);
            this.txt_genero_consulta.TabIndex = 16;
            this.txt_genero_consulta.Visible = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(140, 64);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(100, 23);
            this.btn_consultar.TabIndex = 15;
            this.btn_consultar.Text = "Consultar Livro";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Visible = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // lbl_livro
            // 
            this.lbl_livro.Location = new System.Drawing.Point(100, 18);
            this.lbl_livro.Name = "lbl_livro";
            this.lbl_livro.Size = new System.Drawing.Size(37, 23);
            this.lbl_livro.TabIndex = 91;
            this.lbl_livro.Text = "Livro:";
            this.lbl_livro.Visible = false;
            // 
            // txt_livro
            // 
            this.txt_livro.Enabled = false;
            this.txt_livro.Location = new System.Drawing.Point(161, 15);
            this.txt_livro.Name = "txt_livro";
            this.txt_livro.Size = new System.Drawing.Size(100, 20);
            this.txt_livro.TabIndex = 71;
            this.txt_livro.Visible = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(252, 35);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(86, 23);
            this.btnCadastro.TabIndex = 70;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(439, 35);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(95, 23);
            this.btnConsulta.TabIndex = 69;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.Location = new System.Drawing.Point(0, 0);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(100, 23);
            this.lblNotaFiscal.TabIndex = 89;
            // 
            // lbl_cadastro_consulta
            // 
            this.lbl_cadastro_consulta.AutoSize = true;
            this.lbl_cadastro_consulta.Location = new System.Drawing.Point(333, 19);
            this.lbl_cadastro_consulta.Name = "lbl_cadastro_consulta";
            this.lbl_cadastro_consulta.Size = new System.Drawing.Size(141, 13);
            this.lbl_cadastro_consulta.TabIndex = 90;
            this.lbl_cadastro_consulta.Text = "Cadastrar ou consultar item?";
            // 
            // lbl_genero
            // 
            this.lbl_genero.Location = new System.Drawing.Point(268, 16);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(47, 23);
            this.lbl_genero.TabIndex = 92;
            this.lbl_genero.Text = "Genero:";
            this.lbl_genero.Visible = false;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(229, 41);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(86, 23);
            this.btn_cadastrar.TabIndex = 94;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Visible = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // gb_cadastro
            // 
            this.gb_cadastro.Controls.Add(this.txt_genero);
            this.gb_cadastro.Controls.Add(this.btn_cadastrar);
            this.gb_cadastro.Controls.Add(this.lbl_genero);
            this.gb_cadastro.Controls.Add(this.lbl_livro);
            this.gb_cadastro.Controls.Add(this.txt_livro);
            this.gb_cadastro.Location = new System.Drawing.Point(81, 64);
            this.gb_cadastro.Name = "gb_cadastro";
            this.gb_cadastro.Size = new System.Drawing.Size(515, 67);
            this.gb_cadastro.TabIndex = 95;
            this.gb_cadastro.TabStop = false;
            this.gb_cadastro.Text = "Cadastro";
            // 
            // txt_genero
            // 
            this.txt_genero.Enabled = false;
            this.txt_genero.Location = new System.Drawing.Point(321, 12);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(100, 20);
            this.txt_genero.TabIndex = 95;
            this.txt_genero.Visible = false;
            // 
            // tbllivrariaBindingSource
            // 
            this.tbllivrariaBindingSource.DataMember = "tbl_livraria";
            this.tbllivrariaBindingSource.DataSource = this.sql10430610DataSetBindingSource;
            // 
            // sql10430610DataSetBindingSource
            // 
            this.sql10430610DataSetBindingSource.DataSource = this.sql10430610DataSet;
            this.sql10430610DataSetBindingSource.Position = 0;
            // 
            // sql10430610DataSet
            // 
            this.sql10430610DataSet.DataSetName = "sql10430610DataSet";
            this.sql10430610DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_livrariaTableAdapter
            // 
            this.tbl_livrariaTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_genero_exibe
            // 
            this.lbl_genero_exibe.AutoSize = true;
            this.lbl_genero_exibe.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero_exibe.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_genero_exibe.Location = new System.Drawing.Point(322, 17);
            this.lbl_genero_exibe.Name = "lbl_genero_exibe";
            this.lbl_genero_exibe.Size = new System.Drawing.Size(78, 22);
            this.lbl_genero_exibe.TabIndex = 86;
            this.lbl_genero_exibe.Text = "Genêro:";
            this.lbl_genero_exibe.Visible = false;
            // 
            // lB_livro
            // 
            this.lB_livro.FormattingEnabled = true;
            this.lB_livro.Location = new System.Drawing.Point(74, 42);
            this.lB_livro.Name = "lB_livro";
            this.lB_livro.Size = new System.Drawing.Size(177, 108);
            this.lB_livro.TabIndex = 96;
            this.lB_livro.Visible = false;
            this.lB_livro.SelectedIndexChanged += new System.EventHandler(this.lB_livro_SelectedIndexChanged);
            // 
            // lB_genero
            // 
            this.lB_genero.FormattingEnabled = true;
            this.lB_genero.Location = new System.Drawing.Point(283, 42);
            this.lB_genero.Name = "lB_genero";
            this.lB_genero.Size = new System.Drawing.Size(177, 108);
            this.lB_genero.TabIndex = 97;
            this.lB_genero.Visible = false;
            // 
            // txt_editar_livro
            // 
            this.txt_editar_livro.Enabled = false;
            this.txt_editar_livro.Location = new System.Drawing.Point(72, 36);
            this.txt_editar_livro.Name = "txt_editar_livro";
            this.txt_editar_livro.Size = new System.Drawing.Size(100, 20);
            this.txt_editar_livro.TabIndex = 99;
            this.txt_editar_livro.Visible = false;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(190, 59);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(104, 23);
            this.btn_confirmar.TabIndex = 100;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Visible = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_editar_genero
            // 
            this.txt_editar_genero.Enabled = false;
            this.txt_editar_genero.Location = new System.Drawing.Point(271, 36);
            this.txt_editar_genero.Name = "txt_editar_genero";
            this.txt_editar_genero.Size = new System.Drawing.Size(100, 20);
            this.txt_editar_genero.TabIndex = 101;
            this.txt_editar_genero.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_genero_editar);
            this.groupBox2.Controls.Add(this.lbl_livro_editar);
            this.groupBox2.Controls.Add(this.txt_editar_genero);
            this.groupBox2.Controls.Add(this.txt_editar_livro);
            this.groupBox2.Location = new System.Drawing.Point(81, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 62);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Atual do Livro";
            // 
            // lbl_genero_editar
            // 
            this.lbl_genero_editar.AutoSize = true;
            this.lbl_genero_editar.Location = new System.Drawing.Point(199, 36);
            this.lbl_genero_editar.Name = "lbl_genero_editar";
            this.lbl_genero_editar.Size = new System.Drawing.Size(45, 13);
            this.lbl_genero_editar.TabIndex = 104;
            this.lbl_genero_editar.Text = "Genêro:";
            this.lbl_genero_editar.Visible = false;
            // 
            // lbl_livro_editar
            // 
            this.lbl_livro_editar.AutoSize = true;
            this.lbl_livro_editar.Location = new System.Drawing.Point(33, 36);
            this.lbl_livro_editar.Name = "lbl_livro_editar";
            this.lbl_livro_editar.Size = new System.Drawing.Size(33, 13);
            this.lbl_livro_editar.TabIndex = 103;
            this.lbl_livro_editar.Text = "Livro:";
            this.lbl_livro_editar.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_genero_novo);
            this.groupBox3.Controls.Add(this.lbl_livro_novo);
            this.groupBox3.Controls.Add(this.txt_genero_novo);
            this.groupBox3.Controls.Add(this.btn_confirmar);
            this.groupBox3.Controls.Add(this.txt_livro_novo);
            this.groupBox3.Location = new System.Drawing.Point(81, 522);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 88);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Novo Registro do Livro";
            // 
            // lbl_genero_novo
            // 
            this.lbl_genero_novo.AutoSize = true;
            this.lbl_genero_novo.Location = new System.Drawing.Point(199, 27);
            this.lbl_genero_novo.Name = "lbl_genero_novo";
            this.lbl_genero_novo.Size = new System.Drawing.Size(45, 13);
            this.lbl_genero_novo.TabIndex = 104;
            this.lbl_genero_novo.Text = "Genêro:";
            this.lbl_genero_novo.Visible = false;
            // 
            // lbl_livro_novo
            // 
            this.lbl_livro_novo.AutoSize = true;
            this.lbl_livro_novo.Location = new System.Drawing.Point(33, 27);
            this.lbl_livro_novo.Name = "lbl_livro_novo";
            this.lbl_livro_novo.Size = new System.Drawing.Size(33, 13);
            this.lbl_livro_novo.TabIndex = 103;
            this.lbl_livro_novo.Text = "Livro:";
            this.lbl_livro_novo.Visible = false;
            // 
            // txt_genero_novo
            // 
            this.txt_genero_novo.Location = new System.Drawing.Point(270, 20);
            this.txt_genero_novo.Name = "txt_genero_novo";
            this.txt_genero_novo.Size = new System.Drawing.Size(100, 20);
            this.txt_genero_novo.TabIndex = 101;
            this.txt_genero_novo.Visible = false;
            // 
            // txt_livro_novo
            // 
            this.txt_livro_novo.Location = new System.Drawing.Point(72, 24);
            this.txt_livro_novo.Name = "txt_livro_novo";
            this.txt_livro_novo.Size = new System.Drawing.Size(100, 20);
            this.txt_livro_novo.TabIndex = 99;
            this.txt_livro_novo.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lB_genero);
            this.groupBox4.Controls.Add(this.lB_livro);
            this.groupBox4.Controls.Add(this.btn_editar);
            this.groupBox4.Controls.Add(this.btnRemover);
            this.groupBox4.Controls.Add(this.lbl_genero_exibe);
            this.groupBox4.Controls.Add(this.lbl_livro_exibe);
            this.groupBox4.Location = new System.Drawing.Point(81, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 185);
            this.groupBox4.TabIndex = 106;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista dos Livros Cadastrados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 614);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_cadastro);
            this.Controls.Add(this.lbl_cadastro_consulta);
            this.Controls.Add(this.lblSenhaInvalida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblNotaFiscal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_cadastro.ResumeLayout(false);
            this.gb_cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbllivrariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql10430610DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql10430610DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lbl_livro_exibe;
        private System.Windows.Forms.Label lbl_genero_consulta;
        private System.Windows.Forms.Label lblSenhaInvalida;
        private System.Windows.Forms.TextBox txt_livro_consulta;
        private System.Windows.Forms.Label lbl_livro_consulta;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_genero_consulta;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label lbl_livro;
        private System.Windows.Forms.TextBox txt_livro;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.Label lbl_cadastro_consulta;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.GroupBox gb_cadastro;
        private System.Windows.Forms.Button btn_todos_livros;
        private System.Windows.Forms.BindingSource sql10430610DataSetBindingSource;
        private sql10430610DataSet sql10430610DataSet;
        private System.Windows.Forms.BindingSource tbllivrariaBindingSource;
        private sql10430610DataSetTableAdapters.tbl_livrariaTableAdapter tbl_livrariaTableAdapter;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.Label lbl_genero_exibe;
        private System.Windows.Forms.ListBox lB_livro;
        private System.Windows.Forms.ListBox lB_genero;
        private System.Windows.Forms.TextBox txt_editar_livro;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txt_editar_genero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_genero_editar;
        private System.Windows.Forms.Label lbl_livro_editar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_genero_novo;
        private System.Windows.Forms.Label lbl_livro_novo;
        private System.Windows.Forms.TextBox txt_genero_novo;
        private System.Windows.Forms.TextBox txt_livro_novo;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

