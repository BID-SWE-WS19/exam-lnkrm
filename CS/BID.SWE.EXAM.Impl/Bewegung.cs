using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    public class Bewegung
    {
        public virtual string Position()
        {
            return "Position";
        }

        public virtual string Move(int x)
        {
            return "Bewege mich";
        }
    }
}
