using System;
using System.IO;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            Stream s = new MemoryStream();
            using (StreamWriter sw = new StreamWriter(s, leaveOpen: true))
            {
                sw.WriteLine("Frohe Weihnachten");
                sw.WriteLine(42);
                sw.WriteLine(false);
                sw.Flush();
            }

            s.Position = 0;
            return s;
        }

        public object Method2(object obj)
        {
            Stream s = (Stream)obj;

            int intVar;
            string stringVar = "";
            bool boolVar;

            using (StreamReader sr = new StreamReader(s))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    
                    if (Int32.TryParse(line, out int n))
                    {
                        intVar = n;
                        //Console.WriteLine("int found");
                    }
                    else if (Boolean.TryParse(line, out bool b))
                    {
                        boolVar = b;
                        //Console.WriteLine("bool found");
                    }
                    else
                    {
                        stringVar = line;
                    }

                }
            }
            s.Close();
            return stringVar;
        }
    }
}