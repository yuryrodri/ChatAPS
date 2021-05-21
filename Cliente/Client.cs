using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Cliente
{
    public class Client
    {
        public Client(string enderecoIP, int porta, string nomeUsuario)
        {
            _enderecoIP = enderecoIP;
            _porta = porta;
            NomeUsuario = nomeUsuario;
        }
        
        public static EventHandler<StatusChangedEventArgs> StatusChanged;

        private string _enderecoIP;
        private int _porta;
        public static string NomeUsuario;
        public string RespostaLogin;

        private static TcpClient s_tcpConexao;
        private static StreamWriter s_escritorConexao;
        private static StreamReader s_leitorConexao;
        private Thread _threadCliente;

        public void IniciarConexao()
        {
            s_tcpConexao = new TcpClient();
            RespostaLogin = "";
            try
            {
                s_tcpConexao.Connect(_enderecoIP, _porta);
                s_escritorConexao = new StreamWriter(s_tcpConexao.GetStream());
                s_leitorConexao = new StreamReader(s_tcpConexao.GetStream());

                s_escritorConexao.WriteLine(NomeUsuario);
                s_escritorConexao.Flush();

                RespostaLogin = s_leitorConexao.ReadLine();
                if (RespostaLogin[0] == '1')
                {
                    RespostaLogin = "1|Conectado com sucesso!";
                    _threadCliente = new Thread(EscutarMensagens);
                    _threadCliente.IsBackground = true;
                    _threadCliente.Start();
                }
            }
            catch
            {
                RespostaLogin = "0|Erro ao se conectar\r\n"
                    + "O servidor pode estar Offline";
            }
        }
        private void EscutarMensagens()
        {
            try
            {
                while (true)
                {
                    string mensagem = "";
                    OnStatusChanged((mensagem = s_leitorConexao.ReadLine()) != null
                        ? mensagem
                        : throw new Exception());
                }
            }
            catch
            {
                OnStatusChanged("0|Erro, conexão com o servidor perdida");
            }
        }
        public static void EnviarMensagem(string Mensagem)
        {
            s_escritorConexao.WriteLine(Mensagem.Trim());
            s_escritorConexao.Flush();
        }
        private void OnStatusChanged(string mensagem)
        {
            if (StatusChanged != null)
                StatusChanged(this, new StatusChangedEventArgs(mensagem));
        }
    }
}
