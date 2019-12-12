using System;
using System.Collections.Generic;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class MySecondCell : Cell
    {
        public override int Grow()
        {
            return this._size * 2;
        }
    }
}
