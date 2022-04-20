using System.Collections.Generic;
using System;
using System.IO;
using Framework.Communication;
using Framework.Command;

namespace Framework.Device
{
    public class Arduino : IDevice
    {
        private ICommunication protocol;
        public void createProtocol(ICommunication protocol)
        {
            this.protocol = protocol;
        }
        public void Send(ICommand command)
        {
            protocol.Send(command);
        }

        public void Receive()
        {
            protocol.Receive();
        }

        public void Transmit()
        {

        }

        public void Dispose()
        {

        }
    }
}