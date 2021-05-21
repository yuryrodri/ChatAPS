using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cliente
{
    public partial class FormChat : Form
    {
        public FormChat()
        {
            InitializeComponent();
            Client.StatusChanged += OnStatusChanged;
            lblNome.Text += Client.NomeUsuario;
        }

        private void Enviar()
        {
            if(txbMensagem.Text.Trim() != "")
            {
                Client.EnviarMensagem(txbMensagem.Text);
                txbMensagem.Text = "";
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }
        private void txbMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Enviar();
                e.Handled = true;
            }
            cmbEmoticons.DroppedDown = false;
        }
        private void cmbEmoticons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Emoticons emoticons = new Emoticons();
            txbMensagem.AppendText($" {emoticons.ListaEmoticons[cmbEmoticons.SelectedIndex]} ");
            txbMensagem.Focus();
            cmbEmoticons.DroppedDown = true;
        }

        private delegate void AtualizaLog(string mensagem);
        private void OnStatusChanged(object sender, StatusChangedEventArgs args)
        {
            Invoke(new AtualizaLog(AtualizaLogMensagens),
                new object[] { args.MensagemServidor });
        }
        private void AtualizaLogMensagens(string mensagem)
        {
            if (mensagem[0].ToString() == "0")
            {
                MessageBox.Show(mensagem.Substring(2));
                Application.Exit();
            }
            else
            {
                txbLog.AppendText($"{mensagem}\r\n");
            }
        }

        //TRATAMENTOS DE FORMULÁRIO
        private void frmChat_Shown(object sender, EventArgs e)
        {
            cmbEmoticons.Items.Clear();
            Emoticons emotes = new Emoticons();
            foreach (string emoticon in emotes.ListaEmoticons)
            {
                cmbEmoticons.Items.Add(emoticon.ToString());
            }
            btnEnviar.Focus();
        }
        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Point PosicaoMouse;
        private void pnlMoverJanela_MouseDown(object sender, MouseEventArgs e)
        {
            PosicaoMouse = new Point(e.X, e.Y);
        }
        private void pnlMoverJanela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - PosicaoMouse.X;
                Top += e.Y - PosicaoMouse.Y;
            }
        }
        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
