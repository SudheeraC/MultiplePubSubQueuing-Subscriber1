using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Subscriber1
{
    class MessageHandler : IHandleMessages<One>
    {
        public void Handle(One message)
        {
           //do some processing.
           Console.WriteLine("Subscriber1+" + message.message);
        }
    }
}
