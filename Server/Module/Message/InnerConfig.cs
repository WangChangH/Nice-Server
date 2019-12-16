using MongoDB.Bson.Serialization.Attributes;

namespace Server
{
    [NoObjectPool]
    [BsonIgnoreExtraElements]
    public class InnerConfig : AConfigComponent
    {
        public string Address { get; set; }
    }
}
