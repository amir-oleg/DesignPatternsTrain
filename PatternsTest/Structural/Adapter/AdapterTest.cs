using DesignPatternsTrain.Structural.Adapter;
using NUnit.Framework;

namespace PatternsTest.Structural.Adapter
{
    class AdapterTest
    {
        private INotify _adapter;

        [SetUp]
        public void Init()
        {
            _adapter = new DesignPatternsTrain.Structural.Adapter.Adapter();
        }

        [Test]
        public void LogicTest()
        {
            _adapter.Notify();
        }
    }
}
