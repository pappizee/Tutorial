using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = ClassLibraryPractice.Class1.Addition(10, 5);
            Assert.AreEqual(result, 15);

            // Common short cut commands :
            //Peek Alt f12 lets know what the code does
            //Cntrl tab to flick through tabs
            //Cntrl S to save
            //Back space to undo
            //dll : dynamic link library
            // read about character escape sequence
        }
    }
}
