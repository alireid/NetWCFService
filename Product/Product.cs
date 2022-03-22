
namespace ProductBL
{
    using System;
    using System.Runtime.Serialization;

    // This is our Data Object
    
    [Serializable]
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Desc { get; set; }
    }
}
