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
            _threadValidacao = new Thread(ValidarUsuario);
            _threadValidacao.Start();
        }

        private TcpClient _tcpClient;
        private Thread _threadValidacao;
        private StreamReader _leitorConexao;
        private StreamWriter _escritorConexao;
        private string _usuarioAtual;

        private void ValidarUsuario()
        {
            _leitorConexao = new StreamReader(_tcpClient.GetStream()); 
            _escritorConexao = new StreamWriter(_tcpClient.GetStream());
            _usuarioAtual = _leitorConexao.ReadLine();

            if (Server.Usuarios.Count >= 10)
            {
                _escritorConexao.WriteLine("0|Limite de usuários atingido.");
                _escritorConexao.Flush();
                FechaConexao();
                return;
            }
            if (_usuarioAtual != "")
            {
                if (Server.Usuarios.Contains(_usuarioAtual))
                {
                    _escritorConexao.WriteLine("0|Este nome de usuário já existe.");
                    _escritorConexao.Flush();
                    FechaConexao();
                    return;
                }
                else if (_usuarioAtual.ToLower() == "administrador")
                {
                    _escritorConexao.WriteLine("0|Este nome de usuário é reservado.");
                    _escritorConexao.Flush();
                    FechaConexao();
                    return;
                }
                else
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
        private void AguardarMensagem() 
        {
            try
            {
                while (true)
                {
                    Server.ValidarMensagem(_usuarioAtual, _leitorConexao.ReadLine());
                }
            }
            catch (Exception)
            {
                RemoverUsuario(_usuarioAtual);
            }
        }
        private void RemoverUsuario(string usuarioAtual)
        {
            if (Server.Usuarios[usuarioAtual] != null)
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
