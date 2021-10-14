using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Client : IInfo
    {
        public Client(uint computerNumber) => ComputerNumber = computerNumber;

        public Client(Person person, uint computerNumber, DateTime recordingTime, DateTime endTime)
            : this(computerNumber)
        {
            Person = person;
            RecordingTime = recordingTime;
            EndTime = endTime;
        }

        public Person Person { get; set; }
        public uint ComputerNumber { get; set; }
        public DateTime RecordingTime { get; set; }
        public DateTime EndTime { get; set; }
        public string GetInfo() => "\n\tComputer number: " + ComputerNumber +
            "\n\tRecording time: " + RecordingTime + "\n\tEnd time: " + EndTime; 
    }
}
