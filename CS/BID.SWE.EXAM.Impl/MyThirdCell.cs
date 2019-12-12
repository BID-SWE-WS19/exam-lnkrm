using System;
using System.Collections.Generic;
using System.Text;
using BID.SWE1.Exam.Interfaces;


namespace BID.SWE.EXAM.Impl
{
    public class MyThirdCell : Cell
    {
        public bool IsAlive(int neighbours)
        {
            if(neighbours%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
