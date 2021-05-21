using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Cliente
{
    public class Client
    {
        public Client()
        {

        }

        public Client(string enderecoIP, int porta, string nomeUsuario)
        {
            _enderecoIP = enderecoIP;
            _porta = porta;
            _nomeUsuario = nomeUsuario;
        }

        public string RespostaLogin; //Resultado recebido pelo servidor sobre a conexão
        public static string _nomeUsuario;
        public static EventHandler<StatusChangedEventArgs> StatusChanged;

        private string _enderecoIP;
        private int _porta;
        private Thread _threadCliente; //Thread que ficará ouvindo as mensagens do servidor em segundo plano
        private static TcpClient _tcpServidor; //Conexão do Usuário com o servidor
        private static StreamWriter _escritorConexao; //Responsável por escrever para o servidor
        private static StreamReader _leitorConexao; //Responsável por ler informações recebidas pelo servidor

        public void Conectar()
        {
            _tcpServidor = new TcpClient(); //Instancia uma nova conexão TCP
            RespostaLogin = "";
            try
            {
                _tcpServidor.Connect(_enderecoIP, _porta);//Tenta se conectar ao IP/Porta
                _escritorConexao = new StreamWriter(_tcpServidor.GetStream());//Atribui a conexão ao escritor para poder escrever nela
                _leitorConexao = new StreamReader(_tcpServidor.GetStream());//Atribui a conexão ao leitor para poder ler os dados na conexão

                _escritorConexao.WriteLine(_nomeUsuario); //Escreve na conexão o nome de usuário para ser enviado ao servidor
                _escritorConexao.Flush();//Envia o nome de usuário ao servidor para que ele valide

                if ((RespostaLogin = _leitorConexao.ReadLine())[0] == '1')//Atribui a resposta do servidor e em seguida verifica se é positiva ('1')
                {
                    RespostaLogin = "1|Conectado com sucesso!";
                    _threadCliente = new Thread(EscutarMensagens); //Inicia o método Escutar mensagens numaa thread para ouvir mensagens do servidor
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
                    OnStatusChanged((mensagem = _leitorConexao.ReadLine()) != null
                        ? mensagem
                        : throw new Exception());
                }
            }
            catch //Caso de algum problema ao ler a linha do servidor
            {
                OnStatusChanged("0|Erro, conexão com o servidor perdida");
            }
        }
        public static void EnviarMensagem(string Mensagem)
        {
            _escritorConexao.WriteLine(Mensagem.Trim()); //Escreve a mensagem na conexão
            _escritorConexao.Flush();//Envia a mensagem
        }
        private void OnStatusChanged(string mensagem) //Aciona o evento para executar os métodos vinculados
        {
            if (StatusChanged != null)
                StatusChanged(this, new StatusChangedEventArgs(mensagem));
        }
    }
}
