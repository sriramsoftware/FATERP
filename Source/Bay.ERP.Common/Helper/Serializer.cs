using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;


namespace Bay.ERP.Common.Helper
{
	public static class Serializer
	{
		[DebuggerStepThrough()]
		public static void Serialize<T>(Stream stream, T target) where T:class
		{
			byte[] cipherBytes = Crypto.Encrypt<T>(target);
			stream.Write(cipherBytes, 0, cipherBytes.Length);
		}

		[DebuggerStepThrough()]
		public static void Serialize<T>(string file, T target) where T:class
		{
			using(FileStream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
			{
				Serialize<T>(stream, target);
			}
		}
		
		[DebuggerStepThrough()]
        public static T Deserialize<T>(Stream stream) where T : class
		{
			byte[] cipherBytes = new byte[stream.Length];
			stream.Read(cipherBytes, 0, cipherBytes.Length);

            return Crypto.Decrypt<T>(cipherBytes) as T;
		}

		[DebuggerStepThrough()]
        public static T Deserialize<T>(string file) where T : class
		{
			if (File.Exists(file))
			{
				using(FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					return Deserialize<T>(stream) as T;
				}
			}

			return null;
		}

        [DebuggerStepThrough()]
        public static byte[] ToBytes<T>(T target) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(ms, target);

                ms.Seek(0, SeekOrigin.Begin);

                return ms.ToArray();
            }
        }

        [DebuggerStepThrough()]
        public static T FromBytes<T>(byte[] array) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(array, 0, array.Length);
                ms.Seek(0, SeekOrigin.Begin);

                return (new BinaryFormatter()).Deserialize(ms) as T;
            }
        }

        public static string ToXml<T>(T target) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (TextWriter tw = new StreamWriter(ms))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(ms, target);
                    ms.Seek(0, SeekOrigin.Begin);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(ms);

                    return xmlDoc.OuterXml;

                }
            }
        }

        public static void ToXmlFile<T>(T target, string filePath) where T : class
        {
            using (TextWriter tw = new StreamWriter(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(tw, target);
            }
        }

        public static T FromXml<T>(string xml) where T : class
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (TextWriter tw = new StreamWriter(ms))
                {
                    tw.Write(xml);
                }

                ms.Seek(0, SeekOrigin.Begin);

                XmlSerializer serializer = new XmlSerializer(typeof(T));

                return serializer.Deserialize(ms) as T;
            }
        }
	}
}