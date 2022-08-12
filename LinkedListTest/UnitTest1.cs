using LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenValue_When30_ThenSearchTheNode()
        {
            Linked_List linkedList = new Linked_List();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            Node node = linkedList.Search(30);
            Assert.AreEqual(30, node.data);
        }
    }
}
