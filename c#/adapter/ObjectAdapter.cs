using System;
using System.Collections.Generic;

namespace adapter
{
    internal class ObjectAdapter : ITargetInterface
    {
        private readonly Adaptee _adaptee;

        public ObjectAdapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public List<double> GetOperands()
        {
            return new List<double> { _adaptee.GetFirstOperand(), _adaptee.GetSecondOperand() };
        }

        public double sum()
        {
            return _adaptee.ComputeSum();
        }

        public double max()
        {
            return _adaptee.max();
        }

        public double multiply()
        {
            return _adaptee.GetFirstOperand()*_adaptee.GetSecondOperand();
        }
    }
}