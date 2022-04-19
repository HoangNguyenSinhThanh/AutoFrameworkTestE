using System.Collections.Generic;
using System;
using System.IO;
using Framework.Command;

namespace Framework.Communication
{
    public interface ICommunication : IDisposable
    {
        void Send(ICommand command);
        string Receive();
    }
}