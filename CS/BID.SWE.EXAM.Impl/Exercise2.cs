using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            return new MyCell();
        }

        public int Method2()
        {
            MySecondCell cellObj = new MySecondCell();
            return cellObj.Grow();
        }

        public bool Method3(int o1)
        {
            MyThirdCell cellObj = new MyThirdCell();
            return cellObj.IsAlive(o1);
        }
    }
}