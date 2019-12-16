using System;

namespace Server
{
    public class ActorMessageAttribute : Attribute
    {
        public ushort Opcode { get; private set; }

        public ActorMessageAttribute(ushort opcode)
        {
            this.Opcode = opcode;
        }
    }
}
