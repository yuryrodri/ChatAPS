
namespace Cliente
{
    partial class FormChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
            this.lblSair = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.pnlMoverJanela = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txbMensagem = new System.Windows.Forms.TextBox();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.picEmoticons = new System.Windows.Forms.PictureBox();
            this.cmbEmoticons = new System.Windows.Forms.ComboBox();
            this.pnlMensagem = new System.Windows.Forms.Panel();
            this.pnlMoverJanela.SuspendLayout();
            this.pnlLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmoticons)).BeginInit();
            this.pnlMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(354, 8);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(24, 24);
            this.lblSair.TabIndex = 14;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(325, 9);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(23, 22);
            this.lblMinimizar.TabIndex = 0;
            this.lblMinimizar.Text = "─";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // pnlMoverJanela
            // 
            this.pnlMoverJanela.Controls.Add(this.lblMinimizar);
            this.pnlMoverJanela.Controls.Add(this.lblNome);
            this.pnlMoverJanela.Controls.Add(this.lblSair);
            this.pnlMoverJanela.Location = new System.Drawing.Point(1, 2);
            this.pnlMoverJanela.Name = "pnlMoverJanela";
            this.pnlMoverJanela.Size = new System.Drawing.Size(390, 33);
            this.pnlMoverJanela.TabIndex = 15;
            this.pnlMoverJanela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.pnlMoverJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(11, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(160, 24);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Conectado como:";
            this.lblNome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.lblNome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(302, 409);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(77, 54);
            this.btnEnviar.TabIndex = 17;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txbMensagem
            // 
            this.txbMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbMensagem.Location = new System.Drawing.Point(3, 0);
            this.txbMensagem.Multiline = true;
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.PlaceholderText = "Digite sua mensagem...";
            this.txbMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMensagem.Size = new System.Drawing.Size(275, 54);
            this.txbMensagem.TabIndex = 16;
            this.txbMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMensagem_KeyPress);
            // 
            // txbLog
            // 
            this.txbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLog.ForeColor = System.Drawing.Color.Black;
            this.txbLog.Location = new System.Drawing.Point(3, 0);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ReadOnly = true;
            this.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLog.Size = new System.Drawing.Size(364, 354);
            this.txbLog.TabIndex = 0;
            // 
            // pnlLog
            // 
            this.pnlLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pnlLog.Controls.Add(this.txbLog);
            this.pnlLog.Location = new System.Drawing.Point(12, 41);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(367, 354);
            this.pnlLog.TabIndex = 18;
            // 
            // picEmoticons
            // 
            this.picEmoticons.BackColor = System.Drawing.Color.Transparent;
            this.picEmoticons.Enabled = false;
            this.picEmoticons.Image = ((System.Drawing.Image)(resources.GetObject("picEmoticons.Image")));
            this.picEmoticons.Location = new System.Drawing.Point(258, 0);
            this.picEmoticons.Name = "picEmoticons";
            this.picEmoticons.Size = new System.Drawing.Size(20, 54);
            this.picEmoticons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmoticons.TabIndex = 20;
            this.picEmoticons.TabStop = false;
            // 
            // cmbEmoticons
            // 
            this.cmbEmoticons.DropDownHeight = 500;
            this.cmbEmoticons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmoticons.DropDownWidth = 50;
            this.cmbEmoticons.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEmoticons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEmoticons.FormattingEnabled = true;
            this.cmbEmoticons.IntegralHeight = false;
            this.cmbEmoticons.Location = new System.Drawing.Point(258, 15);
            this.cmbEmoticons.Name = "cmbEmoticons";
            this.cmbEmoticons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbEmoticons.Size = new System.Drawing.Size(20, 33);
            this.cmbEmoticons.TabIndex = 19;
            this.cmbEmoticons.SelectedIndexChanged += new System.EventHandler(this.cmbEmoticons_SelectedIndexChanged);
            // 
            // pnlMensagem
            // 
            this.pnlMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pnlMensagem.Controls.Add(this.picEmoticons);
            this.pnlMensagem.Controls.Add(this.cmbEmoticons);
            this.pnlMensagem.Controls.Add(this.txbMensagem);
            this.pnlMensagem.Location = new System.Drawing.Point(12, 409);
            this.pnlMensagem.Name = "pnlMensagem";
            this.pnlMensagem.Size = new System.Drawing.Size(278, 54);
            this.pnlMensagem.TabIndex = 19;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(391, 478);
            this.Controls.Add(this.pnlMensagem);
            this.Controls.Add(this.pnlLog);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pnlMoverJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Sustentável";
            this.Shown += new System.EventHandler(this.frmChat_Shown);
            this.pnlMoverJanela.ResumeLayout(false);
            this.pnlMoverJanela.PerformLayout();
            this.pnlLog.ResumeLayout(false);
            this.pnlLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmoticons)).EndInit();
            this.pnlMensagem.ResumeLayout(false);
            this.pnlMensagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Panel pnlMoverJanela;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txbMensagem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Panel pnlMensagem;
        private System.Windows.Forms.ComboBox cmbEmoticons;
        private System.Windows.Forms.PictureBox picEmoticons;
    }
}