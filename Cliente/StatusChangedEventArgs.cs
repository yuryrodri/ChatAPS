using System;

namespace Cliente
{
    public class StatusChangedEventArgs : EventArgs
    {
        public string MensagemServidor { get; set; }

        public StatusChangedEventArgs(string mensagemSevidor)
        {
            MensagemServidor = mensagemSevidor;
        }
    }
}
