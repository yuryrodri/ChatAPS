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
            EnderecoIp = enderecoIp;
            Porta = porta;
        }

        public static Hashtable Usuarios = new Hashtable(10);
        public static EventHandler<StatusChangedEventArgs> StatusChanged;

        private IPAddress EnderecoIp;
        private int Porta;
        private TcpClient TcpServer = new TcpClient();
        private Thread ThreadListener;
        private TcpListener ListenerServidor;
        private bool ServidorRodando = false;

        public void IniciarServidor()
        {
            ListenerServidor = new TcpListener(EnderecoIp, Porta);
            ListenerServidor.Start();

            ServidorRodando = true;

            ThreadListener = new Thread(ManterServidor);
            ThreadListener.IsBackground = true;
            ThreadListener.Start();
        }
        private void ManterServidor()
        {
            while (ServidorRodando)
            {
                try
                {
                    TcpServer = ListenerServidor.AcceptTcpClient();
                    ConexaoUsuario novaConexao = new ConexaoUsuario(TcpServer); 
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
            OnStatusChanged($"Adminstrador: {mensagem}");
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
            ServidorRodando = false;
            try
            {
                foreach (TcpClient clienteConectado in Usuarios.Values)
                {
                    clienteConectado.Close();
                }
            }
            catch{ }
            ListenerServidor.Stop();
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
