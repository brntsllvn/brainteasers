using LinkedLists;
using NUnit.Framework;
using Shouldly;

namespace LinkedListsTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void FindKthElementTest()
        {
            var r = new NodeRunner();
            
            Node case1 = null;
            int k1 = 2;
            
            Node case2 = new Node(1);
            case2.next = new Node(2);
            case2.next.next = new Node(3);
            int k2 = 0;

            Node case3 = new Node(1);
            case3.next = new Node(2);
            case3.next.next = new Node(3);
            int k3 = 1;
            
            Node case4 = new Node(1);
            case4.next = new Node(2);
            case4.next.next = new Node(3);
            int k4 = 2;

            Node case5 = new Node(1);
            case5.next = new Node(2);
            case5.next.next = new Node(3);
            int k5 = 3;

            Node case6 = new Node(1);
            case6.next = new Node(2);
            case6.next.next = new Node(3);
            int k6 = 4;
            
            true.ShouldSatisfyAllConditions(
                () => r.FindKthToLastElement(case1, k1).ShouldBe(-1),
                () => r.FindKthToLastElement(case2, k2).ShouldBe(-1),
                () => r.FindKthToLastElement(case3, k3).ShouldBe(3),
                () => r.FindKthToLastElement(case4, k4).ShouldBe(2),
                () => r.FindKthToLastElement(case5, k5).ShouldBe(1),
                () => r.FindKthToLastElement(case6, k6).ShouldBe(-1) 
            );
        }
    }
}