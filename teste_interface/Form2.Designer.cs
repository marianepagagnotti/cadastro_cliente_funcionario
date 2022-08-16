namespace teste_interface
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrarCli = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCompl = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.txtRuaCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxDado1 = new System.Windows.Forms.GroupBox();
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTelCli = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lv_cliente = new System.Windows.Forms.ListView();
            this.col_codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_datanasc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_rua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_compl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnResgatar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxDado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(722, 134);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 32);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrarCli
            // 
            this.btnCadastrarCli.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCadastrarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCli.Location = new System.Drawing.Point(655, 70);
            this.btnCadastrarCli.Name = "btnCadastrarCli";
            this.btnCadastrarCli.Size = new System.Drawing.Size(102, 50);
            this.btnCadastrarCli.TabIndex = 16;
            this.btnCadastrarCli.Text = "CADASTRAR CLIENTE";
            this.btnCadastrarCli.UseVisualStyleBackColor = false;
            this.btnCadastrarCli.Click += new System.EventHandler(this.btnCadastrarCli_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.comboBoxCompl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxCidade);
            this.groupBox1.Controls.Add(this.txtRuaCli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBairroCli);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 150);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Endereço";
            // 
            // comboBoxCompl
            // 
            this.comboBoxCompl.FormattingEnabled = true;
            this.comboBoxCompl.Items.AddRange(new object[] {
            "Apartamento",
            "Casa",
            "Outro"});
            this.comboBoxCompl.Location = new System.Drawing.Point(126, 115);
            this.comboBoxCompl.Name = "comboBoxCompl";
            this.comboBoxCompl.Size = new System.Drawing.Size(79, 21);
            this.comboBoxCompl.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(16, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Complemento :";
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Items.AddRange(new object[] {
            "Bauru",
            "Bariri",
            "Jaú",
            "Bocaina",
            "Dois Córregos"});
            this.comboBoxCidade.Location = new System.Drawing.Point(82, 36);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(79, 21);
            this.comboBoxCidade.TabIndex = 11;
            // 
            // txtRuaCli
            // 
            this.txtRuaCli.Location = new System.Drawing.Point(63, 76);
            this.txtRuaCli.Name = "txtRuaCli";
            this.txtRuaCli.Size = new System.Drawing.Size(237, 20);
            this.txtRuaCli.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rua :";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(394, 76);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(60, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(322, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número :";
            // 
            // txtBairroCli
            // 
            this.txtBairroCli.Location = new System.Drawing.Point(237, 37);
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.Size = new System.Drawing.Size(345, 20);
            this.txtBairroCli.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(185, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(16, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cidade :";
            // 
            // groupBoxDado1
            // 
            this.groupBoxDado1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxDado1.Controls.Add(this.mskDataNasc);
            this.groupBoxDado1.Controls.Add(this.msktxtTelCli);
            this.groupBoxDado1.Controls.Add(this.pictureBox1);
            this.groupBoxDado1.Controls.Add(this.label3);
            this.groupBoxDado1.Controls.Add(this.label2);
            this.groupBoxDado1.Controls.Add(this.txtNomeCli);
            this.groupBoxDado1.Controls.Add(this.label1);
            this.groupBoxDado1.Controls.Add(this.txtCodCliente);
            this.groupBoxDado1.Controls.Add(this.lblCodigo);
            this.groupBoxDado1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxDado1.Location = new System.Drawing.Point(12, 11);
            this.groupBoxDado1.Name = "groupBoxDado1";
            this.groupBoxDado1.Size = new System.Drawing.Size(625, 169);
            this.groupBoxDado1.TabIndex = 14;
            this.groupBoxDado1.TabStop = false;
            this.groupBoxDado1.Text = "Dados do Cliente";
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Location = new System.Drawing.Point(167, 119);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(80, 20);
            this.mskDataNasc.TabIndex = 14;
            this.mskDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // msktxtTelCli
            // 
            this.msktxtTelCli.Location = new System.Drawing.Point(341, 119);
            this.msktxtTelCli.Mask = "(999) 000-0000";
            this.msktxtTelCli.Name = "msktxtTelCli";
            this.msktxtTelCli.Size = new System.Drawing.Size(127, 20);
            this.msktxtTelCli.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(491, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 115);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Nascimento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(264, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone :";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(69, 76);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(404, 20);
            this.txtNomeCli.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome :";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(151, 36);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(74, 20);
            this.txtCodCliente.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigo.Location = new System.Drawing.Point(16, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(129, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código do Cliente :";
            // 
            // lv_cliente
            // 
            this.lv_cliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_codigo,
            this.col_nome,
            this.col_datanasc,
            this.col_telefone,
            this.col_bairro,
            this.col_rua,
            this.col_num,
            this.col_compl,
            this.col_cidade});
            this.lv_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_cliente.FullRowSelect = true;
            this.lv_cliente.HideSelection = false;
            this.lv_cliente.Location = new System.Drawing.Point(12, 356);
            this.lv_cliente.MultiSelect = false;
            this.lv_cliente.Name = "lv_cliente";
            this.lv_cliente.Size = new System.Drawing.Size(862, 166);
            this.lv_cliente.TabIndex = 18;
            this.lv_cliente.UseCompatibleStateImageBehavior = false;
            this.lv_cliente.View = System.Windows.Forms.View.Details;
            // 
            // col_codigo
            // 
            this.col_codigo.Text = "CÓDIGO";
            // 
            // col_nome
            // 
            this.col_nome.Text = "NOME";
            this.col_nome.Width = 150;
            // 
            // col_datanasc
            // 
            this.col_datanasc.Text = "DATA DE NASC.";
            this.col_datanasc.Width = 130;
            // 
            // col_telefone
            // 
            this.col_telefone.Text = "TELEFONE";
            this.col_telefone.Width = 90;
            // 
            // col_bairro
            // 
            this.col_bairro.Text = "BAIRRO";
            this.col_bairro.Width = 110;
            // 
            // col_rua
            // 
            this.col_rua.Text = "RUA";
            this.col_rua.Width = 110;
            // 
            // col_num
            // 
            this.col_num.Text = "NÚMERO";
            // 
            // col_compl
            // 
            this.col_compl.Text = "COMPL.";
            this.col_compl.Width = 70;
            // 
            // col_cidade
            // 
            this.col_cidade.Text = "CIDADE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(867, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResgatar
            // 
            this.btnResgatar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnResgatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResgatar.Location = new System.Drawing.Point(772, 70);
            this.btnResgatar.Name = "btnResgatar";
            this.btnResgatar.Size = new System.Drawing.Size(102, 50);
            this.btnResgatar.TabIndex = 20;
            this.btnResgatar.Text = "RESGATAR OS CAMPOS";
            this.btnResgatar.UseVisualStyleBackColor = false;
            this.btnResgatar.Click += new System.EventHandler(this.btnResgatar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Location = new System.Drawing.Point(812, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(49, 26);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "<-";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnResgatar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv_cliente);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrarCli);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDado1);
            this.Name = "Form2";
            this.Text = "Cadastro de Funcionário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDado1.ResumeLayout(false);
            this.groupBoxDado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrarCli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCompl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.TextBox txtRuaCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairroCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxDado1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ListView lv_cliente;
        private System.Windows.Forms.ColumnHeader col_codigo;
        private System.Windows.Forms.ColumnHeader col_nome;
        private System.Windows.Forms.ColumnHeader col_datanasc;
        private System.Windows.Forms.ColumnHeader col_telefone;
        private System.Windows.Forms.ColumnHeader col_bairro;
        private System.Windows.Forms.ColumnHeader col_rua;
        private System.Windows.Forms.MaskedTextBox msktxtTelCli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResgatar;
        private System.Windows.Forms.ColumnHeader col_num;
        private System.Windows.Forms.ColumnHeader col_compl;
        private System.Windows.Forms.ColumnHeader col_cidade;
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.Button btnVoltar;
    }
}