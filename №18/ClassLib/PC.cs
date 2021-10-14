using System;
using System.Runtime.Serialization;

namespace ClassLib
{
    [Serializable]
    [DataContract]
    public class PC
    {
        [DataMember] private string mark;
        [DataMember] private string serialNumber;
        [DataMember] private string model;
        [DataMember] private string procModel;

        public PC() { }
        public PC(string mark, string serialNumber, string model, string procModel)
        {
            this.mark = mark;
            this.serialNumber = serialNumber;
            this.model = model;
            this.procModel = procModel;
        }

        public string Mark { get => mark; }
        public string SerialNumber { get => serialNumber; }
        public string Model { get => model; }
        public string ProcModel { get => procModel; }

        public string SwitchOn() => "Swith on";
        public string SwitchOff() => "Swith off";
        public string Reboot() => "Reboot";
        public virtual string GetInfo() => "Mark: " + mark + "\nSerial number: "
            + serialNumber + "\nModel: " + model + "\nProcessor: " + procModel;
    }
}
