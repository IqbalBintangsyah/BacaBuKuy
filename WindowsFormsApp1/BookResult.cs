using Newtonsoft.Json;
using System.Collections.Generic;
//kelas di bawah ini sebagai tipe data dari api 
//kelas tidak terpakai
namespace WindowsFormsApp1
{
    class BookResult
    {
        [JsonProperty(PropertyName = "volumeInfo")]
        public VolumeInfo Content { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }
    }

    public class VolumeInfo
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }
        [JsonProperty(PropertyName = "industryIdentifiers")]
        public  IndustryIdentifier industryIdentifier { get; set; }
    }
    
    public class IndustryIdentifier
    {
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
    }
}

