using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Servidor
{
    class Server
    {
        public Server(IPAddress enderecoIp, int porta)
        {
            _enderecoIp = enderecoIp;
            _porta = porta;
        }

        public static Hashtable Usuarios = new Hashtable(10);
        public static EventHandler<StatusChangedEventArgs> StatusChanged;

        private IPAddress _enderecoIp;
        private int _porta;
        private TcpClient _tcpServer = new TcpClient();
        private Thread _threadListener;
        private TcpListener _listenerServidor;
        private bool _servidorRodando = false;

        public void IniciarServidor()
        {
            _listenerServidor = new TcpListener(_enderecoIp, _porta);
            _listenerServidor.Start();

            _servidorRodando = true;

            _threadListener = new Thread(ManterServidor);
            _threadListener.IsBackground = true;
            _threadListener.Start();
        }
        private void ManterServidor()
        {
            while (_servidorRodando)
            {
                try
                {
                    _tcpServer = _listenerServidor.AcceptTcpClient();
                    ConexaoUsuario novaConexao = new ConexaoUsuario(_tcpServer); 
                }
                catch { }
            }
        }
        public static void ValidarMensagem(string usuario, string mensagem)
        {
            string tempMensagem = mensagem.Trim();
            if (tempMensagem != "")
            {
                EnviarMensagem(usuario, tempMensagem);
            }
        }
        private static void EnviarMensagem(string usuario, string mensagem)
        {
            StreamWriter mensagemUsuario;

            OnStatusChanged($"{usuario}: {mensagem}");

            foreach (TcpClient cliente in Usuarios.Values)
            { 
                mensagemUsuario = new StreamWriter(cliente.GetStream());
                mensagemUsuario.WriteLine($"{usuario}: {mensagem}");
                mensagemUsuario.Flush();
            }
        }
        public static void EnviarMensagemAdmin(string mensagem)
        {
            StreamWriter mensagemAdmin;
            OnStatusChanged($"Administrador: {mensagem}");
            foreach (TcpClient cliente in Usuarios.Values)
            {
                if (mensagem.Trim() == "" || cliente == null)
                    continue;
                mensagemAdmin = new StreamWriter(cliente.GetStream());
                mensagemAdmin.WriteLine($"Administrador: {mensagem}");
                mensagemAdmin.Flush();
            }
        }
        private static void OnStatusChanged(string eventMessage)
        {
            if (StatusChanged != null)
            {
                StatusChanged(null, new StatusChangedEventArgs() { EventMessage = eventMessage });
            }
        }
        public void FecharServidor()
        {
            _servidorRodando = false;
            try
            {
                foreach (TcpClient clienteConectado in Usuarios.Values)
                {
                    clienteConectado.Close();
                }
            }
            catch{ }
            _listenerServidor.Stop();
        }
        public static void CriarBackup(string logMensagens)
        {
            string path = @$"C:\Users\{Environment.UserName}" +
            @$"\Desktop\Backup\";
            try
            {
                if (Directory.Exists(path) == false)
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }

                using StreamWriter writer = File.CreateText(
                    @$"{path}\{DateTime.Now:dd-MM-yyyy HHmmss}.txt");
                writer.WriteLine(logMensagens);
            }
            catch { };
        }
    }
}
