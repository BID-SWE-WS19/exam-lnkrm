using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise5 : IExercise5
    {
       
        public object Method1(string str, int i)
        {
            List<string> readData = new List<string>();

            TcpClient client = new TcpClient();
            client.Connect(str, i);
            NetworkStream stream = client.GetStream();

            using (StreamReader sr = new StreamReader(stream))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    readData.Add(line);
                }
            }

            stream.Close();

            return readData;
        }
    }
}