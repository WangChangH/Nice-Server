using System;

namespace Server
{
    public interface IMActorHandler
    {
        ETTask Handle(Session session, Entity entity, object actorMessage);
        Type GetMessageType();
    }
}
