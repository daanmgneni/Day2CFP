using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_PracticeProblem
{
    public class InheritanceClass
    {
           
        protected int variable1;
        protected int variable2;

        public InheritanceClass(int var1, int var2)
        {
            variable1 = var1;
            variable2 = var2;
        }
    }

    
    public class  B : InheritanceClass
    {
        public B(int var1, int var2) : base(var1, var2)
        {
        }

            public void SumVariables()
        {
            int sum = variable1 + variable2;
            Console.WriteLine("Sum of variables: " + sum);
        }
    }
     

}
