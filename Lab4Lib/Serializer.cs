using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab4Lib {
    public class Serializer {
        public static void ToXML(string path, object data, Type type) {
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate)) {
                XmlSerializer xs = new XmlSerializer(type);
                xs.Serialize(file, data);
            }
        }
        public static void ToBinary(string path, object data) {
            using (FileStream file = new FileStream(path,FileMode.OpenOrCreate)) {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, data);
            }
        }
        public static void ToJSON(string path, object data) {
            using (FileStream fs = new FileStream(path,FileMode.OpenOrCreate)) {
                JsonSerializer.SerializeAsync(fs,data);
            }
        }
    }
    public class Deserializer {
        public static void FromXML(string path) {

        }
        public static object FromBinary(string path) {
            using (FileStream fs = new FileStream(path, FileMode.Open)) {
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(fs);
            }
        }
    }
}
