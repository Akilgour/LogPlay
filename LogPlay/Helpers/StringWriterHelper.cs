using System.IO;
using System.Xml.Serialization;

namespace LogPlay.Helpers
{
    public static class StringWriterHelper
    {
        public static string Resolve(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
    }
}