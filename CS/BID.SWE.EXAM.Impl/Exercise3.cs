using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new MyMap();
        }

        public object Method2()
        {
            Laufen laufen = new Laufen();
            Springen springen = new Springen();
            
            Bewegung[] bewegungen = new Bewegung[2];
            bewegungen[0] = laufen;
            bewegungen[1] = springen;

            return bewegungen;
        }

    }
}