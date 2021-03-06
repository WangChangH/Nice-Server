﻿using System;
using System.IO;

namespace Server
{
    public enum ChannelType
    {
        Connect,
        Accept,
    }

    public abstract class AChannel : Entity
    {
        public ChannelType ChannelType { get; }

        public AService Service { get; }

        public abstract MemoryStream Stream { get; }

        public int Error { get; set; }

        public string RemoteAddress { get; protected set; }

        public virtual void Start()
        {
        }

        private Action<AChannel, int> errorCallback;

        public event Action<AChannel, int> ErrorCallback
        {
            add
            {
                this.errorCallback += value;
            }
            remove
            {
                this.errorCallback -= value;
            }
        }

        private Action<MemoryStream> readCallback;

        public event Action<MemoryStream> ReadCallback
        {
            add
            {
                this.readCallback += value;
            }
            remove
            {
                this.readCallback -= value;
            }
        }

        protected void OnRead(MemoryStream memoryStream)
        {
            this.readCallback.Invoke(memoryStream);
        }

        protected void OnError(int e)
        {
            this.Error = e;
            this.errorCallback?.Invoke(this, e);
        }

        protected AChannel(AService service, ChannelType channelType)
        {
            this.Id = IdGenerater.GenerateId();
            this.ChannelType = channelType;
            this.Service = service;
        }

        public abstract void Send(MemoryStream stream);

        public override void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }

            base.Dispose();

            this.Service.Remove(this.Id);
        }
    }
}
