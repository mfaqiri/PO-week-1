using System.Linq;
using Xunit;
using ArraySolver;

namespace ArrayTest
{
    public class ArrayTest
    {

        [Fact]
        public void TestArraySolver(){
            int[] input = new int[] { 14, 12, 70, 15, 99, 65, 21, 90 };
            int sum = 97;
            ContiguousArray TestSolver = new ContiguousArray();
            int[] ExpectedResult = { 12, 70, 15 };
            ContiguousArray.ListNode head = TestSolver.CreateList(input);
            int[] result = TestSolver.ContiguousSum(head, sum);
            bool isEqual = ExpectedResult.SequenceEqual(result);
            Assert.True(isEqual);

        }


        
    }

}