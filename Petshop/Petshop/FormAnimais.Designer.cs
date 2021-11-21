
namespace Petshop
{
    partial class FormAnimais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvAnimais = new System.Windows.Forms.DataGridView();
            this.lblPelagem = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblDatanascimento = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblRaca = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtIDanimal = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIDproprietario = new System.Windows.Forms.TextBox();
            this.lblIDprop = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblPorte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnApgar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtPelagem = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtPorte = new System.Windows.Forms.TextBox();
            this.txtDatanascimento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(180, 23);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 33;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dgvAnimais
            // 
            this.dgvAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimais.Location = new System.Drawing.Point(12, 168);
            this.dgvAnimais.Name = "dgvAnimais";
            this.dgvAnimais.Size = new System.Drawing.Size(385, 171);
            this.dgvAnimais.TabIndex = 32;
            this.dgvAnimais.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimais_CellContentDoubleClick);
            // 
            // lblPelagem
            // 
            this.lblPelagem.AutoSize = true;
            this.lblPelagem.Location = new System.Drawing.Point(11, 126);
            this.lblPelagem.Name = "lblPelagem";
            this.lblPelagem.Size = new System.Drawing.Size(48, 13);
            this.lblPelagem.TabIndex = 28;
            this.lblPelagem.Text = "Pelagem";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(178, 87);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 25;
            this.lblEspecie.Text = "Espécie";
            // 
            // lblDatanascimento
            // 
            this.lblDatanascimento.AutoSize = true;
            this.lblDatanascimento.Location = new System.Drawing.Point(12, 87);
            this.lblDatanascimento.Name = "lblDatanascimento";
            this.lblDatanascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDatanascimento.TabIndex = 24;
            this.lblDatanascimento.Text = "Data de Nascimento";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(269, 64);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(128, 20);
            this.txtRaca.TabIndex = 23;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(269, 48);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 22;
            this.lblRaca.Text = "Raça";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 20);
            this.txtNome.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome";
            // 
            // txtIDanimal
            // 
            this.txtIDanimal.Location = new System.Drawing.Point(12, 25);
            this.txtIDanimal.Name = "txtIDanimal";
            this.txtIDanimal.Size = new System.Drawing.Size(79, 20);
            this.txtIDanimal.TabIndex = 19;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID Animal";
            // 
            // txtIDproprietario
            // 
            this.txtIDproprietario.Location = new System.Drawing.Point(96, 25);
            this.txtIDproprietario.Name = "txtIDproprietario";
            this.txtIDproprietario.Size = new System.Drawing.Size(79, 20);
            this.txtIDproprietario.TabIndex = 35;
            // 
            // lblIDprop
            // 
            this.lblIDprop.AutoSize = true;
            this.lblIDprop.Location = new System.Drawing.Point(95, 9);
            this.lblIDprop.Name = "lblIDprop";
            this.lblIDprop.Size = new System.Drawing.Size(74, 13);
            this.lblIDprop.TabIndex = 34;
            this.lblIDprop.Text = "ID Proprietario";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(131, 142);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(98, 20);
            this.txtPeso.TabIndex = 37;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(129, 126);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 36;
            this.lblPeso.Text = "Peso";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Location = new System.Drawing.Point(234, 126);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(32, 13);
            this.lblPorte.TabIndex = 38;
            this.lblPorte.Text = "Porte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sexo";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(413, 150);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 48;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnApgar
            // 
            this.btnApgar.Location = new System.Drawing.Point(413, 121);
            this.btnApgar.Name = "btnApgar";
            this.btnApgar.Size = new System.Drawing.Size(75, 23);
            this.btnApgar.TabIndex = 47;
            this.btnApgar.Text = "Apagar";
            this.btnApgar.UseVisualStyleBackColor = true;
            this.btnApgar.Click += new System.EventHandler(this.btnApgar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(413, 91);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 46;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(413, 62);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 45;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtPelagem
            // 
            this.txtPelagem.Location = new System.Drawing.Point(12, 142);
            this.txtPelagem.Name = "txtPelagem";
            this.txtPelagem.Size = new System.Drawing.Size(113, 20);
            this.txtPelagem.TabIndex = 49;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(181, 103);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(85, 20);
            this.txtEspecie.TabIndex = 50;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(272, 103);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(125, 20);
            this.txtSexo.TabIndex = 51;
            // 
            // txtPorte
            // 
            this.txtPorte.Location = new System.Drawing.Point(235, 142);
            this.txtPorte.Name = "txtPorte";
            this.txtPorte.Size = new System.Drawing.Size(162, 20);
            this.txtPorte.TabIndex = 52;
            // 
            // txtDatanascimento
            // 
            this.txtDatanascimento.Location = new System.Drawing.Point(14, 103);
            this.txtDatanascimento.Name = "txtDatanascimento";
            this.txtDatanascimento.Size = new System.Drawing.Size(161, 20);
            this.txtDatanascimento.TabIndex = 53;
            // 
            // FormAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 353);
            this.Controls.Add(this.txtDatanascimento);
            this.Controls.Add(this.txtPorte);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtPelagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApgar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPorte);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtIDproprietario);
            this.Controls.Add(this.lblIDprop);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.dgvAnimais);
            this.Controls.Add(this.lblPelagem);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblDatanascimento);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtIDanimal);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnimais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnimais";
            this.Load += new System.EventHandler(this.FormAnimais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.DataGridView dgvAnimais;
        private System.Windows.Forms.Label lblPelagem;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblDatanascimento;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIDanimal;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtIDproprietario;
        private System.Windows.Forms.Label lblIDprop;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnApgar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtPelagem;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtPorte;
        private System.Windows.Forms.TextBox txtDatanascimento;
    }
}