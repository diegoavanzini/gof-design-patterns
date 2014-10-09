using System.Collections.Generic;

namespace adapter
{
    internal interface ITargetInterface
    {
        List<double> GetOperands();

        double sum();

        double max();

        /**
         * This operation is not among Adaptee's ones
         */
        double multiply();

    }
}