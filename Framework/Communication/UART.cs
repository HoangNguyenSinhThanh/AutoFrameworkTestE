using System.Collections.Generic;
using System;
using System.IO;
using Framework.Command;

namespace Framework.Communication
{
    public class UART : ICommunication
    {
        public void Send(ICommand command)
        {

        }
        public string Receive()
        {
            return "DraftUART";
        }

        public void Dispose()
        {

        }
    }
}