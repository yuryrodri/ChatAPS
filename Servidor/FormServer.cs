using Servidor;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace ChatAPS
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }

        private delegate void AtualizaLogCallBack(string mensagem);
        private bool _servidorRodando = false;
        private Server _servidor;

        private void btnCriarServidor_Click(object sender, EventArgs e)
        {
            if (_servidorRodando == false)
            {
                if (txbIp.Text == "")
                {
                    MessageBox.Show("Informe o endereço de IP");
                    txbIp.Focus();
                    return;
                }
                try
                {
                    IPAddress enderecoIp = IPAddress.Parse(txbIp.Text);
                    int porta = (int)upDownPort.Value;

                    _servidor = new Server(enderecoIp, porta);
                    Server.StatusChanged += OnServidorStatusChanged;
                    _servidor.IniciarServidor();

                    txbLog.Text = "";
                    txbLog.AppendText("Esperando conexões...\r\n");

                    _servidorRodando = true;
                    btnCriarServidor.Text = "Fechar servidor";
                    txbMensagem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Server.StatusChanged -= OnServidorStatusChanged;
                LogFecharServidor();
                CriarBackup();
                _servidor.FecharServidor();
                _servidorRodando = false;
                txbMensagem.Enabled = false;
                btnCriarServidor.Text = "Criar servidor";
            }
        }
        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
        }
        private void txbMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                EnviarMensagem();
                e.Handled = true;
            }
        }
        private void EnviarMensagem()
        {
            string mensagem = txbMensagem.Text.Trim();
            if (mensagem != "")
            {
                Server.EnviarMensagemAdmin(mensagem);
                txbMensagem.Focus();
            }
            txbMensagem.Text = "";
        }
        private void OnServidorStatusChanged(object sender, StatusChangedEventArgs args)
        {
            Invoke(new AtualizaLogCallBack(AtualizaLog),
                    new object[] { args.EventMessage });//Executa o método AtualizaStatus quando solicitado pelo Evento
        }
        private void AtualizaLog(string mensagem)
        {
            txbLog.AppendText($"{mensagem}\r\n");
        }
        private void LogFecharServidor()
        {
            txbLog.AppendText($"==========================================\r\n" +
                $"Usuarios desconectados:\r\n");

            foreach (string nomeUsuario in Server.Usuarios.Keys)
            {
                txbLog.AppendText($"->    {nomeUsuario}\r\n");
            }
            txbLog.AppendText($"==========================================\r\n");
            txbLog.AppendText($"Horário desconexão: " +
                $"{DateTime.Now:dd/MM/yyyy - HH:mm}\r\n");
            txbLog.AppendText($"==========================================");
        }
        private void CriarBackup()
        {
            if (_servidorRodando)
            {
                Server.CriarBackup(txbLog.Text);
            }
        }

        //TRATAMENTOS DE FORMULÁRIO...IGNORAR
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
            CriarBackup();

            Application.Exit();
        }
    }
}