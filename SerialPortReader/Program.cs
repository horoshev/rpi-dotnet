using System;
using System.IO.Ports;

namespace SerialPortReader
{
    class Program
    {
        private static readonly SerialPort WeightSerialPort = new("/dev/serial0");

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (WeightSerialPort.IsOpen)
            {
                var line = WeightSerialPort.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}