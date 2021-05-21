
using Servidor;

namespace ChatAPS
{
    partial class FormServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.pnlMoverJanela = new System.Windows.Forms.Panel();
            this.lblNomeFormulario = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.upDownPort = new System.Windows.Forms.NumericUpDown();
            this.btnCriarServidor = new System.Windows.Forms.Button();
            this.txbIp = new System.Windows.Forms.TextBox();
            this.picIP = new System.Windows.Forms.PictureBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txbMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.pnlMoverJanela.SuspendLayout();
            this.pnlLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMoverJanela
            // 
            this.pnlMoverJanela.Controls.Add(this.lblNomeFormulario);
            this.pnlMoverJanela.Controls.Add(this.lblMinimizar);
            this.pnlMoverJanela.Controls.Add(this.lblSair);
            this.pnlMoverJanela.Location = new System.Drawing.Point(0, 1);
            this.pnlMoverJanela.Name = "pnlMoverJanela";
            this.pnlMoverJanela.Size = new System.Drawing.Size(503, 33);
            this.pnlMoverJanela.TabIndex = 16;
            this.pnlMoverJanela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.pnlMoverJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // lblNomeFormulario
            // 
            this.lblNomeFormulario.AutoSize = true;
            this.lblNomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeFormulario.ForeColor = System.Drawing.Color.White;
            this.lblNomeFormulario.Location = new System.Drawing.Point(15, 7);
            this.lblNomeFormulario.Name = "lblNomeFormulario";
            this.lblNomeFormulario.Size = new System.Drawing.Size(123, 24);
            this.lblNomeFormulario.TabIndex = 15;
            this.lblNomeFormulario.Text = "Chat Servidor";
            this.lblNomeFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.lblNomeFormulario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(439, 9);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(23, 22);
            this.lblMinimizar.TabIndex = 0;
            this.lblMinimizar.Text = "─";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(468, 8);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(24, 24);
            this.lblSair.TabIndex = 14;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // pnlLog
            // 
            this.pnlLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pnlLog.Controls.Add(this.txbLog);
            this.pnlLog.Location = new System.Drawing.Point(12, 84);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(480, 354);
            this.pnlLog.TabIndex = 19;
            // 
            // txbLog
            // 
            this.txbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLog.Location = new System.Drawing.Point(1, 0);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ReadOnly = true;
            this.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLog.Size = new System.Drawing.Size(479, 354);
            this.txbLog.TabIndex = 0;
            // 
            // upDownPort
            // 
            this.upDownPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.upDownPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upDownPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upDownPort.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownPort.Location = new System.Drawing.Point(222, 47);
            this.upDownPort.Maximum = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            this.upDownPort.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.upDownPort.Name = "upDownPort";
            this.upDownPort.Size = new System.Drawing.Size(65, 29);
            this.upDownPort.TabIndex = 22;
            this.upDownPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // btnCriarServidor
            // 
            this.btnCriarServidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCriarServidor.Location = new System.Drawing.Point(325, 46);
            this.btnCriarServidor.Name = "btnCriarServidor";
            this.btnCriarServidor.Size = new System.Drawing.Size(167, 31);
            this.btnCriarServidor.TabIndex = 21;
            this.btnCriarServidor.Text = "Criar servidor";
            this.btnCriarServidor.UseVisualStyleBackColor = true;
            this.btnCriarServidor.Click += new System.EventHandler(this.btnCriarServidor_Click);
            // 
            // txbIp
            // 
            this.txbIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbIp.Location = new System.Drawing.Point(51, 47);
            this.txbIp.Name = "txbIp";
            this.txbIp.PlaceholderText = "127.0.0.1";
            this.txbIp.Size = new System.Drawing.Size(150, 29);
            this.txbIp.TabIndex = 20;
            this.txbIp.Text = "127.0.0.1";
            // 
            // picIP
            // 
            this.picIP.Image = ((System.Drawing.Image)(resources.GetObject("picIP.Image")));
            this.picIP.Location = new System.Drawing.Point(15, 46);
            this.picIP.Name = "picIP";
            this.picIP.Size = new System.Drawing.Size(30, 30);
            this.picIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIP.TabIndex = 23;
            this.picIP.TabStop = false;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorta.ForeColor = System.Drawing.Color.White;
            this.lblPorta.Location = new System.Drawing.Point(203, 49);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(16, 24);
            this.lblPorta.TabIndex = 24;
            this.lblPorta.Text = ":";
            // 
            // txbMensagem
            // 
            this.txbMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMensagem.Enabled = false;
            this.txbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbMensagem.Location = new System.Drawing.Point(13, 452);
            this.txbMensagem.Multiline = true;
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.PlaceholderText = "Digite sua mensagem...";
            this.txbMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMensagem.Size = new System.Drawing.Size(379, 54);
            this.txbMensagem.TabIndex = 25;
            this.txbMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMensagem_KeyPress);
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviarMensagem.BackgroundImage")));
            this.btnEnviarMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviarMensagem.FlatAppearance.BorderSize = 0;
            this.btnEnviarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMensagem.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnviarMensagem.Location = new System.Drawing.Point(399, 452);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(93, 54);
            this.btnEnviarMensagem.TabIndex = 26;
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(504, 520);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.txbMensagem);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.picIP);
            this.Controls.Add(this.upDownPort);
            this.Controls.Add(this.btnCriarServidor);
            this.Controls.Add(this.txbIp);
            this.Controls.Add(this.pnlLog);
            this.Controls.Add(this.pnlMoverJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.pnlMoverJanela.ResumeLayout(false);
            this.pnlMoverJanela.PerformLayout();
            this.pnlLog.ResumeLayout(false);
            this.pnlLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMoverJanela;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.NumericUpDown upDownPort;
        private System.Windows.Forms.Button btnCriarServidor;
        private System.Windows.Forms.TextBox txbIp;
        private System.Windows.Forms.PictureBox picIP;
        private System.Windows.Forms.Label lblNomeFormulario;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.TextBox txbMensagem;
        private System.Windows.Forms.Button btnEnviarMensagem;
    }
}