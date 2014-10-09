using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace adapter
{
    [TestFixture]
    class adapter_test
    {
        Adaptee _adaptee;

        [SetUp]
        public void Init()
        {
            _adaptee = new Adaptee(3.2, 6.7);
        }

        [Test]
        public void call_to_sum_method_on_ObjectAdapter_should_return_sum()
        {
            ITargetInterface objectAdapter = new ObjectAdapter(_adaptee);

            Assert.That(objectAdapter.sum(), Is.EqualTo(3.2 + 6.7));
        }

        [Test]
        public void call_to_max_method_on_ObjectAdapter_should_return_max()
        {
            ITargetInterface objectAdapter = new ObjectAdapter(_adaptee);

            Assert.That(objectAdapter.max(), Is.EqualTo(Math.Max(3.2, 6.7)));
        }

        [Test]
        public void call_to_method_getFirstOperand_on_ObjectAdapter_should_return_the_first_operand()
        {
            ITargetInterface objectAdapter = new ObjectAdapter(_adaptee);
            Assert.That(objectAdapter.GetOperands()[0], Is.EqualTo(_adaptee.GetFirstOperand()));
        }

        [Test]
        public void call_to_method_multiply_on_ObjectAdapter_should_return_the_moltiplication()
        {
            ITargetInterface objectAdapter = new ObjectAdapter(_adaptee);
            Assert.That(objectAdapter.multiply(), Is.EqualTo(3.2 * 6.7));
        }


        [Test]
        public void call_to_method_getOperands_on_ObjectAdapter_should_return_the_list_of_operands()
        {
            ITargetInterface objectAdapter = new ObjectAdapter(_adaptee);
            Assert.That(objectAdapter.GetOperands(), Is.EqualTo(new List<double> { 3.2, 6.7 }));
        }




        [Test]
        public void call_to_sum_method_on_ClassAdapter_should_return_sum()
        {
            ITargetInterface classAdapter = new ClassAdapter(3.2, 6.7);

            Assert.That(classAdapter.sum(), Is.EqualTo(3.2 + 6.7));
        }

        [Test]
        public void call_to_max_method_on_ClassAdapter_should_return_max()
        {
            ITargetInterface classAdapter = new ClassAdapter(3.2, 6.7);

            Assert.That(classAdapter.max(), Is.EqualTo(Math.Max(3.2, 6.7)));
        }

        [Test]
        public void call_to_method_getFirstOperand_on_ClassAdapter_should_return_the_first_operand()
        {
            ITargetInterface classAdapter = new ClassAdapter(3.2, 6.7);
            Assert.That(classAdapter.GetOperands()[0], Is.EqualTo(_adaptee.GetFirstOperand()));
        }

        [Test]
        public void call_to_method_multiply_on_ClassAdapter_should_return_the_moltiplication()
        {
            ITargetInterface classAdapter = new ClassAdapter(3.2, 6.7);
            Assert.That(classAdapter.multiply(), Is.EqualTo(3.2 * 6.7));
        }

        [Test]
        public void call_to_method_getOperands_on_ClassAdapter_should_return_the_list_of_operands()
        {
            ITargetInterface classAdapter = new ClassAdapter(3.2, 6.7);
            Assert.That(classAdapter.GetOperands(), Is.EqualTo(new List<double> { 3.2, 6.7 }));
        }
    }
}
