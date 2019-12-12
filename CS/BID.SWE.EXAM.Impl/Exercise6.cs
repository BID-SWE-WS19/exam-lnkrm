using System;
using System.Data.SqlClient;
using BID.SWE1.Exam.Interfaces;
using System.Data.SqlClient;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {
            // SqlCommand cmd = new SqlCommand(@"INSERT INTO TestAbgaben (Tag, Monat, Jahr, Stunde, Minute, Name) VALUES (12, 12, 2019, 17, 00, Lena)");

            SqlCommand cmd = new SqlCommand(@"INSERT INTO [TestAbgaben] ([Tag], [Monat], [Jahr], [Stunde], [Minute], [Name]) VALUES (@d, @m, @y, @h, @min, @n)");
            cmd.Parameters.AddWithValue("@d", 12);
            cmd.Parameters.AddWithValue("@m", 12);
            cmd.Parameters.AddWithValue("@y", 2019);
            cmd.Parameters.AddWithValue("@h", 17);
            cmd.Parameters.AddWithValue("@min", 00);
            cmd.Parameters.AddWithValue("@n", "Lena");

            return cmd;
        }
    }
}