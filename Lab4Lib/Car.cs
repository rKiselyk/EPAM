using System;
using System.Runtime.Serialization;

namespace Lab4Lib {


    [DataContract]
    [Serializable]
    public class Car {
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public string Color { get; set; }

        public Car() { }
        public Car(string model, string number, string color) {
            this.Model = model;
            this.Number = number;
            this.Color = color;
        }

        public override string ToString() {
            return $"{Model}\t{Number}\t{Color}";
        }
    }
}
