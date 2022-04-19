using System.Collections.Generic;
using System;
using System.IO;
using Framework.Command;

namespace Framework.Communication
{
    public class SPI : ICommunication
    {
        public void Send(ICommand command)
        {

        }
        public string Receive()
        {
            return "DraftSPI";
        }

        public void Dispose()
        {

        }
    }
}