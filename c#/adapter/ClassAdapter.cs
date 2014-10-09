using System;
using System.Collections.Generic;

namespace adapter
{
    internal class ClassAdapter : Adaptee, ITargetInterface
    {
        public ClassAdapter(double operand1, double operand2)
            : base(operand1, operand2)
        {
        }

        public List<double> GetOperands()
        {
            return new List<double> {GetFirstOperand(), GetSecondOperand()};
        }

        public double sum()
        {
            return ComputeSum();
        }

        public double multiply()
        {
            return GetFirstOperand()*GetSecondOperand();
        }
    }
}