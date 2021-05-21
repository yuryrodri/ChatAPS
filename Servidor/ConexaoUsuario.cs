using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Servidor
{
    class ConexaoUsuario
    {
        public ConexaoUsuario(TcpClient cliente)
        {
            _tcpClient = cliente;
            _threadValidacao = new Thread(ValidarUsuario); //Inicia o método Validar Usuário em uma Thread para não parar o Servidor
            _threadValidacao.Start();
        }

        private TcpClient _tcpClient; //Conexão do usuário
        private Thread _threadValidacao; //Thread que envia ao usuário o resultado da validação (Aceito ou não aceito)
        private StreamReader _leitorConexao; //Ouve as mensagens do cliente
        private StreamWriter _escritorConexao; //Envia as mensagens para cliente
        private string _usuarioAtual; //Nome do usuário

        private void ValidarUsuario()
        {
            _leitorConexao = new StreamReader(_tcpClient.GetStream()); //Atribui a conexão que será lida pelo receptor
            _escritorConexao = new StreamWriter(_tcpClient.GetStream()); //Atribui a conexão a qual o escritor escreverá
            _usuarioAtual = _leitorConexao.ReadLine(); //Le o nome de usuário recebido pela conexão

            if (Server.Usuarios.Count >= 10) //se já atingiu o limite de usuários conectados
            {
                _escritorConexao.WriteLine("0|Limite de usuários atingido.");
                _escritorConexao.Flush();
                FechaConexao();
                return;
            }
            if (_usuarioAtual != "") //Se o nome de usuário não é vazio
            {
                if (Server.Usuarios.Contains(_usuarioAtual)) //Verificar se o nome de usuário já existe
                {
                    _escritorConexao.WriteLine("0|Este nome de usuário já existe.");
                    _escritorConexao.Flush();
                    FechaConexao();
                    return;
                }
                else if (_usuarioAtual.ToLower() == "administrador") //Verificar se o nome de usuário não é de administrador
                {
                    _escritorConexao.WriteLine("0|Este nome de usuário é reservado.");
                    _escritorConexao.Flush();
                    FechaConexao();
                    return;
                }
                else //Tudo certo, cliente pode se conectar
                {
                    _escritorConexao.WriteLine("1");
                    _escritorConexao.Flush();

                    AceitarUsuario(_tcpClient, _usuarioAtual);
                }
            }
            else
            {
                FechaConexao();
                return;
            }
        }
        private void AceitarUsuario(TcpClient cliente, string usuarioAtual)
        {
            Server.Usuarios.Add(usuarioAtual, cliente);
            Server.EnviarMensagemAdmin($"{usuarioAtual} se conectou.");
            AguardarMensagem();
        }
        private void AguardarMensagem() //Fica ouvindo todas as mensagens enviadas por um usuários
        {
            try
            {
                while (true) //Atribui a linha lida no leitor de conexão e avalia se ela é diferente de null
                {
                    Server.ValidarMensagem(_usuarioAtual, _leitorConexao.ReadLine());//valida a mensagem recebida para ser enviada
                }
            }
            catch (Exception)
            {
                RemoverUsuario(_usuarioAtual);
            }
        }
        private void RemoverUsuario(string usuarioAtual)
        {
            if (Server.Usuarios[usuarioAtual] != null)//Se o usuário esta na lista, exclui ele da lista de usuários conectados
            {
                Server.Usuarios.Remove(usuarioAtual);
                Server.EnviarMensagemAdmin($"{usuarioAtual} se desconectou. (" +
                    $"{DateTime.Now:HH:mm})");
            }
        }
        private void FechaConexao()
        {
            _tcpClient.Close();
            _leitorConexao.Close();
            _escritorConexao.Close();
        }
    }
}
