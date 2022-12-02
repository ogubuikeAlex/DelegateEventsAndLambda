using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsAndLambda.FUnctionalProgramming
{
    internal class AnnonymousMethods
    {
        public void Run()
        {
            Func<string, int> MethodA = delegate (string name)
            {
                return name.Length;
            };

            MethodA += delegate (string month)
            {
                return month.Length * 2;
            };         
           
        }

        public int MethodB(string sumthing)
        {
            return sumthing.Length;
        }
    }
}
