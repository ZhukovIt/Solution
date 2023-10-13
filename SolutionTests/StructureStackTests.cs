using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution.Structures;
using Xunit;

namespace SolutionTests.Structures
{
    public sealed class StructureStackTests
    {
        [Fact]
        public void Stack_Can_Clear_All_Objects()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            sut.Clear();

            Assert.Equal(0, sut.Count);
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Item_Contains_In_Stack()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            bool result = sut.Contains(1);

            Assert.True(result);
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Item_Not_Contains_In_Stack()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            bool result = sut.Contains(10);

            Assert.False(result);
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Stack_Can_Add_Item_In_End()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            sut.Push(6);

            Assert.Equal(6, sut.Count);
            Assert.Equal(6, sut.Items.Last());
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Stack_Can_Take_Last_Item_And_Remove_His_From_Items()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            int result = sut.Pop();

            Assert.Equal(4, sut.Count);
            Assert.Equal(5, result);
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Stack_Can_Take_Some_Last_Items_And_Remove_Their_From_Items()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            System.Collections.Generic.IEnumerable<int> result = sut.Pop(3);

            Assert.Equal(2, sut.Count);
            Assert.Equal(3, result.Count());
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Method_Pop_Can_Not_Take_More_Items_Than_Are_On_The_Stack()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            Assert.Throws(typeof(InvalidOperationException), new Action(() =>
            {
                sut.Pop(6);
            }));
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Empty_Stack_Throws_Invalid_Operation_Exception_If_Try_Execute_Pop_Method_With_Count_Parameter()
        {
            Stack<int> sut = new Stack<int>();

            Assert.Equal(0, sut.Count);
            Assert.Throws(typeof(InvalidOperationException), new Action(() =>
            {
                sut.Pop(1);
            }));
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Empty_Stack_Throws_Invalid_Operation_Exception_If_Try_Execute_Pop_Method()
        {
            Stack<int> sut = new Stack<int>();

            Assert.Equal(0, sut.Count);
            Assert.Throws(typeof(InvalidOperationException), new Action(() =>
            {
                sut.Pop();
            }));
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Stack_Can_Only_Take_Last_Item()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            int result = sut.Peek();

            Assert.Equal(5, sut.Count);
            Assert.Equal(5, result);
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Empty_Stack_Throws_Invalid_Operation_Exception_If_Try_Execute_Peek_Method()
        {
            Stack<int> sut = new Stack<int>();

            Assert.Equal(0, sut.Count);
            Assert.Throws(typeof(InvalidOperationException), new Action(() =>
            {
                sut.Peek();
            }));
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Stack_Can_Take_Some_Last_Items()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            System.Collections.Generic.IEnumerable<int> result = sut.Peek(3);

            Assert.Equal(5, sut.Count);
            Assert.Equal(3, result.Count());
            Assert.Equal(5, result.Select((number, index) => new { number, index }).First(x => x.index == 0).number);
            Assert.Equal(4, result.Select((number, index) => new { number, index }).First(x => x.index == 1).number);
            Assert.Equal(3, result.Select((number, index) => new { number, index }).First(x => x.index == 2).number);
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Method_Peek_Can_Not_Take_More_Items_Than_Are_On_The_Stack()
        {
            var _Objects = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> sut = new Stack<int>(_Objects);

            Assert.Throws(typeof(InvalidOperationException), new Action(() =>
            {
                sut.Peek(6);
            }));
        }
        //------------------------------------------------------------------------------------
        [Fact]
        public void Empty_Stack_Throws_Invalid_Operation_Exception_If_Try_Execute_Peek_Method_With_Count_Parameter()
        {
            Stack<int> sut = new Stack<int>();

            Assert.Equal(0, sut.Count);
            Assert.Throws(typeof(InvalidOperationException), new Action(() =>
            {
                sut.Peek(1);
            }));
        }
        //------------------------------------------------------------------------------------
    }
}
