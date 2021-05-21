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

        private delegate void AtualizaStatusCallBack(string mensagem); //Delegate que será vinculado ao evento da classe servidor
        private bool _servidorRodando = false;
        private Server _servidor; //Classe do servidor que será instanciada posteriormente

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
                    IPAddress enderecoIp = IPAddress.Parse(txbIp.Text);//Verifica se o IP digitado é válido
                    int porta = (int)upDownPort.Value;

                    _servidor = new Server(enderecoIp, porta); //Se a validação funcionou ele inicia o servidor
                    Server.StatusChanged += OnServidorStatusChanged; //Vincula o método OnServidorStatusChanged ao evento
                    _servidor.IniciarServidor();

                    txbLog.Text = "";
                    txbLog.AppendText("Esperando conexões...\r\n");

                    _servidorRodando = true;
                    btnCriarServidor.Text = "Fechar servidor";
                    txbMensagem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()); //Exibe o erro em uma messageBox
                }
            }
            else
            {
                Server.StatusChanged -= OnServidorStatusChanged;//Desvincula o método OnServidorStatusChanged ao evento
                LogFecharServidor();
                _servidor.FecharServidor();
                btnCriarServidor.Text = "Criar servidor";
                txbMensagem.Enabled = false;
                CriarBackup();
                _servidorRodando = false;
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
            if (txbMensagem.Text.Trim() != "")
            {
                Server.EnviarMensagemAdmin(txbMensagem.Text);
                txbMensagem.Text = "";
                txbMensagem.Focus();
            }
        }
        private void OnServidorStatusChanged(object sender, StatusChangedEventArgs args)
        {
            Invoke(new AtualizaStatusCallBack(AtualizaLog),
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