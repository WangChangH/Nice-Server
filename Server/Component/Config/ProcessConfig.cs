namespace Server
{
    [NoObjectPool]
    public class ProcessConfig : AConfigComponent
    {
        public string ServerIP { get; set; }
    }
}
