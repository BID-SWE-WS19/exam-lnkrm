using System;
using System.Collections.Generic;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class CellPrinter : ICellPrinter
    {
        public string PrintPostion(int x, int y)
        {
            return $"Cell is on Position X:{x} Y:{y}";
        }

        public string PrintState(bool alive, DateTime date, string color)
        {
            if (alive)
            {
                return $"Cell {color} born on {date.Day}.{date.Month}.{date.Year} is alive";
            }
            else
            {
                return $"Cell {color} born on {date} is dead";
            }
            
        }
    }
}
