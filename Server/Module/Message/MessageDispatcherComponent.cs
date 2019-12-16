using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    /// <summary>
	/// 消息分发组件
	/// </summary>
	public class MessageDispatcherComponent : Entity
    {
        public static MessageDispatcherComponent Instace { get; set; }
        public readonly Dictionary<ushort, List<IMHandler>> Handlers = new Dictionary<ushort, List<IMHandler>>();
    }
}
