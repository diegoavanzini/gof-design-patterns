using System;

namespace adapter
{
    internal class Adaptee
    {
        private readonly double _operand1;
        private readonly double _operand2;

        public Adaptee(double operand1, double operand2)
        {
            _operand1 = operand1;
            _operand2 = operand2;
        }

        public double ComputeSum()
        {
            return _operand1 + _operand2;
        }

        public double max()
        {
            return Math.Max(_operand1, _operand2);
        }

        public double GetFirstOperand()
        {
            return _operand1;
        }

        public double GetSecondOperand()
        {
            return _operand2;
        }
    }
}