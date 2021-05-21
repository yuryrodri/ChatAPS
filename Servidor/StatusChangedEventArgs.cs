using System;

namespace Servidor
{
    public class StatusChangedEventArgs : EventArgs
    {
        public string EventMessage { get; set; }

        public StatusChangedEventArgs()
        {
        }
    }
}
