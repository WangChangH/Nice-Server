using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    // 客户端为了0GC需要消息池，服务端消息需要跨协程不需要消息池
    public class MessagePool
    {
        public static MessagePool Instance { get; } = new MessagePool();


        public object Fetch(Type type)
        {

			return Activator.CreateInstance(type);

        }

        public T Fetch<T>() where T : class
        {
            T t = (T)this.Fetch(typeof(T));
            return t;
        }

        public void Recycle(object obj)
        {

        }
    }
}
