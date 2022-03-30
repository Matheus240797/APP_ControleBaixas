namespace APP_AbatimentoCobranca_1._0 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbContrato = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridClientes = new System.Windows.Forms.DataGridView();
            this.pnForm1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseForm1 = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).BeginInit();
            this.pnForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(241, 68);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(400, 23);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Controls.Add(this.rbCPF);
            this.groupBox1.Controls.Add(this.rbContrato);
            this.groupBox1.Location = new System.Drawing.Point(23, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa:";
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(19, 55);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(60, 19);
            this.rbNome.TabIndex = 1;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "NOME";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(19, 28);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(46, 19);
            this.rbCPF.TabIndex = 0;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // rbContrato
            // 
            this.rbContrato.AutoSize = true;
            this.rbContrato.Location = new System.Drawing.Point(19, 82);
            this.rbContrato.Name = "rbContrato";
            this.rbContrato.Size = new System.Drawing.Size(85, 19);
            this.rbContrato.TabIndex = 2;
            this.rbContrato.TabStop = true;
            this.rbContrato.Text = "CONTRATO";
            this.rbContrato.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o texto a ser procurado:";
            // 
            // dtGridClientes
            // 
            this.dtGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridClientes.Location = new System.Drawing.Point(23, 178);
            this.dtGridClientes.Name = "dtGridClientes";
            this.dtGridClientes.ReadOnly = true;
            this.dtGridClientes.RowTemplate.Height = 25;
            this.dtGridClientes.Size = new System.Drawing.Size(704, 212);
            this.dtGridClientes.TabIndex = 0;
            this.dtGridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridClientes_CellDoubleClick);
            // 
            // pnForm1
            // 
            this.pnForm1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnForm1.Controls.Add(this.label2);
            this.pnForm1.Controls.Add(this.btnCloseForm1);
            this.pnForm1.Location = new System.Drawing.Point(-1, 0);
            this.pnForm1.Name = "pnForm1";
            this.pnForm1.Size = new System.Drawing.Size(752, 25);
            this.pnForm1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "GRUPO | AKRK - Recebimento Cobrança";
            // 
            // btnCloseForm1
            // 
            this.btnCloseForm1.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCloseForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseForm1.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm1.Location = new System.Drawing.Point(722, 3);
            this.btnCloseForm1.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseForm1.Name = "btnCloseForm1";
            this.btnCloseForm1.Size = new System.Drawing.Size(20, 20);
            this.btnCloseForm1.TabIndex = 0;
            this.btnCloseForm1.Text = "X";
            this.btnCloseForm1.UseVisualStyleBackColor = false;
            this.btnCloseForm1.Click += new System.EventHandler(this.btnCloseForm1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(647, 65);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(30, 28);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Location = new System.Drawing.Point(683, 65);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(30, 28);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(750, 409);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pnForm1);
            this.Controls.Add(this.dtGridClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).EndInit();
            this.pnForm1.ResumeLayout(false);
            this.pnForm1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPesquisar;
        private GroupBox groupBox1;
        private RadioButton rbNome;
        private RadioButton rbCPF;
        private RadioButton rbContrato;
        private Label label1;
        private DataGridView dtGridClientes;
        private Panel pnForm1;
        private Button btnCloseForm1;
        private Label label2;
        private Button btnPesquisar;
        private Button btnAtualizar;
    }
}