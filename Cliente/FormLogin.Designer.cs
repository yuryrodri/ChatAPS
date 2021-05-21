
namespace Cliente
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.picIP = new System.Windows.Forms.PictureBox();
            this.upDownPorta = new System.Windows.Forms.NumericUpDown();
            this.pnlLinhaIP = new System.Windows.Forms.Panel();
            this.pnlLinhaPorta = new System.Windows.Forms.Panel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.pnlLinhaUsuario = new System.Windows.Forms.Panel();
            this.txbNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMoverJanela = new System.Windows.Forms.Panel();
            this.lblMinimizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlMoverJanela.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(262, 245);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txbIP
            // 
            this.txbIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.txbIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbIP.ForeColor = System.Drawing.Color.White;
            this.txbIP.Location = new System.Drawing.Point(48, 289);
            this.txbIP.MaxLength = 15;
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(141, 22);
            this.txbIP.TabIndex = 1;
            this.txbIP.Text = "127.0.0.1";
            // 
            // picIP
            // 
            this.picIP.Image = ((System.Drawing.Image)(resources.GetObject("picIP.Image")));
            this.picIP.Location = new System.Drawing.Point(12, 287);
            this.picIP.Name = "picIP";
            this.picIP.Size = new System.Drawing.Size(30, 30);
            this.picIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIP.TabIndex = 2;
            this.picIP.TabStop = false;
            // 
            // upDownPorta
            // 
            this.upDownPorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.upDownPorta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upDownPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upDownPorta.ForeColor = System.Drawing.SystemColors.Window;
            this.upDownPorta.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownPorta.Location = new System.Drawing.Point(212, 290);
            this.upDownPorta.Maximum = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            this.upDownPorta.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.upDownPorta.Name = "upDownPorta";
            this.upDownPorta.Size = new System.Drawing.Size(62, 25);
            this.upDownPorta.TabIndex = 4;
            this.upDownPorta.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // pnlLinhaIP
            // 
            this.pnlLinhaIP.BackColor = System.Drawing.Color.White;
            this.pnlLinhaIP.Location = new System.Drawing.Point(48, 313);
            this.pnlLinhaIP.Name = "pnlLinhaIP";
            this.pnlLinhaIP.Size = new System.Drawing.Size(141, 2);
            this.pnlLinhaIP.TabIndex = 5;
            // 
            // pnlLinhaPorta
            // 
            this.pnlLinhaPorta.BackColor = System.Drawing.Color.White;
            this.pnlLinhaPorta.Location = new System.Drawing.Point(212, 313);
            this.pnlLinhaPorta.Name = "pnlLinhaPorta";
            this.pnlLinhaPorta.Size = new System.Drawing.Size(41, 2);
            this.pnlLinhaPorta.TabIndex = 6;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(12, 341);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(30, 30);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabIndex = 7;
            this.picUsuario.TabStop = false;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(250, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(24, 24);
            this.lblSair.TabIndex = 8;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // pnlLinhaUsuario
            // 
            this.pnlLinhaUsuario.BackColor = System.Drawing.Color.White;
            this.pnlLinhaUsuario.Location = new System.Drawing.Point(48, 368);
            this.pnlLinhaUsuario.Name = "pnlLinhaUsuario";
            this.pnlLinhaUsuario.Size = new System.Drawing.Size(205, 2);
            this.pnlLinhaUsuario.TabIndex = 10;
            // 
            // txbNomeUsuario
            // 
            this.txbNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.txbNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.txbNomeUsuario.Location = new System.Drawing.Point(48, 345);
            this.txbNomeUsuario.MaxLength = 20;
            this.txbNomeUsuario.Name = "txbNomeUsuario";
            this.txbNomeUsuario.Size = new System.Drawing.Size(226, 22);
            this.txbNomeUsuario.TabIndex = 9;
            this.txbNomeUsuario.Text = "Nome de Usuário";
            this.txbNomeUsuario.Click += new System.EventHandler(this.txbNomeUsuario_Click);
            this.txbNomeUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNomeUsuario_KeyPress);
            this.txbNomeUsuario.Leave += new System.EventHandler(this.txbNomeUsuario_Leave);
            // 
            // btnConectar
            // 
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(12, 405);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(262, 44);
            this.btnConectar.TabIndex = 11;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(193, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // pnlMoverJanela
            // 
            this.pnlMoverJanela.Controls.Add(this.lblMinimizar);
            this.pnlMoverJanela.Location = new System.Drawing.Point(0, 1);
            this.pnlMoverJanela.Name = "pnlMoverJanela";
            this.pnlMoverJanela.Size = new System.Drawing.Size(286, 33);
            this.pnlMoverJanela.TabIndex = 13;
            this.pnlMoverJanela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.pnlMoverJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(221, 9);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(23, 22);
            this.lblMinimizar.TabIndex = 0;
            this.lblMinimizar.Text = "─";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(286, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.pnlLinhaUsuario);
            this.Controls.Add(this.txbNomeUsuario);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.pnlLinhaPorta);
            this.Controls.Add(this.pnlLinhaIP);
            this.Controls.Add(this.upDownPorta);
            this.Controls.Add(this.picIP);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlMoverJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Sustentável";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlMoverJanela.ResumeLayout(false);
            this.pnlMoverJanela.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox picIP;
        private System.Windows.Forms.NumericUpDown upDownPorta;
        private System.Windows.Forms.Panel pnlLinhaIP;
        private System.Windows.Forms.Panel pnlLinhaPorta;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Panel pnlLinhaUsuario;
        private System.Windows.Forms.TextBox txbNomeUsuario;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMoverJanela;
        private System.Windows.Forms.Label lblMinimizar;
    }
}