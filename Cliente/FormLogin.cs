using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cliente
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Conectar()
        {
            Validacao validacao = new Validacao(txbIP.Text, txbNomeUsuario.Text);
            string resposta = validacao.ValidarDadosConexao();
            if (resposta != "")
            {
                MessageBox.Show(resposta);
            }
            else
            {
                Client cliente = new Client
                    (txbIP.Text, int.Parse(upDownPorta.Text), txbNomeUsuario.Text);
                cliente.IniciarConexao();
                MessageBox.Show(cliente.RespostaLogin.Substring(2));
                if (cliente.RespostaLogin[0] == '1')
                {
                    Hide();
                    FormChat chat = new FormChat();
                    chat.ShowDialog();
                    Close();
                }
            }
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }
        private void txbNomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Conectar();
                e.Handled = true;
            }
        }

        //TRATAMENTOS DE FORMULÁRIO...IGNORAR
        private void txbNomeUsuario_Click(object sender, EventArgs e)
        {
            if (txbNomeUsuario.Text.Trim() == "Nome de Usuário")
            {
                txbNomeUsuario.Text = "";
            }
        }
        private void txbNomeUsuario_Leave(object sender, EventArgs e)
        {
            if (txbNomeUsuario.Text.Trim() == "")
            {
                txbNomeUsuario.Text = "Nome de Usuário";
            }
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
