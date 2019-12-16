using System;

namespace Server
{
    public interface IMHandler
    {
        ETVoid Handle(Session session, object message);
        Type GetMessageType();
    }
}
