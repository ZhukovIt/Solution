using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public sealed class BaseballGameSolution
    {
        public int CalPoints(string[] operations)
        {
            Stack<int> stack = new Stack<int>();
            
            foreach (string operation in operations)
            {
                InterpretOperation(operation).Invoke(stack);
            }

            return stack.Items.Sum();
        }
        //----------------------------------------------------------
        private Action<Stack<int>> InterpretOperation(string _Operation)
        {
            return _Operation switch
            {
                "+" => new Action<Stack<int>>((_Stack) =>
                {
                    _Stack.Push(_Stack.Peek(2).Sum());
                }),
                "D" => new Action<Stack<int>>((_Stack) =>
                {
                    _Stack.Push(_Stack.Peek() * 2);
                }),
                "C" => new Action<Stack<int>>((_Stack) =>
                {
                    _Stack.Pop();
                }),
                _ => new Action<Stack<int>>((_Stack) =>
                {
                    _Stack.Push(int.Parse(_Operation));
                }),
            };
        }
        //----------------------------------------------------------
        private sealed class Stack<T>
        {
            private List<T> m_Items;
            //----------------------------------------------------------
            public int Count
            {
                get
                {
                    return m_Items.Count;
                }
            }
            //----------------------------------------------------------
            public IEnumerable<T> Items
            {
                get
                {
                    return m_Items;
                }
            }
            //----------------------------------------------------------
            public Stack()
            {
                m_Items = new List<T>();
            }
            //----------------------------------------------------------
            public Stack(IEnumerable<T> _Items)
            {
                m_Items = (List<T>)_Items;
            }
            //----------------------------------------------------------
            public void Clear()
            {
                m_Items = new List<T>();
            }
            //----------------------------------------------------------
            public bool Contains(T _Item)
            {
                return m_Items.Contains(_Item);
            }
            //----------------------------------------------------------
            public void Push(T _Item)
            {
                m_Items.Add(_Item);
            }
            //----------------------------------------------------------
            public T Pop()
            {
                if (m_Items.Count == 0)
                {
                    throw new InvalidOperationException("Попытка получить первый элемент из пустого стека!");
                }

                T _LastItem = m_Items.Last();

                m_Items.RemoveAt(m_Items.LastIndexOf(_LastItem));

                return _LastItem;
            }
            //----------------------------------------------------------
            public IEnumerable<T> Pop(int _CountLastItems)
            {
                if (m_Items.Count == 0)
                {
                    throw new InvalidOperationException("Попытка получить первый элемент из пустого стека!");
                }

                if (m_Items.Count < _CountLastItems)
                {
                    throw new InvalidOperationException("Попытка получить больше элементов, чем есть в стеке!");
                }

                List<T> _Result = new List<T>();

                for (int i = _CountLastItems - 1; i >= 0; i--)
                {
                    _Result.Add(m_Items[i]);

                    m_Items.RemoveAt(m_Items.LastIndexOf(m_Items[i]));
                }

                return _Result;
            }
            //----------------------------------------------------------
            public T Peek()
            {
                if (m_Items.Count == 0)
                {
                    throw new InvalidOperationException("Попытка получить первый элемент из пустого стека!");
                }

                return m_Items.Last();
            }
            //----------------------------------------------------------
            public IEnumerable<T> Peek(int _CountLastItems)
            {
                if (m_Items.Count == 0)
                {
                    throw new InvalidOperationException("Попытка получить первый элемент из пустого стека!");
                }

                if (m_Items.Count < _CountLastItems)
                {
                    throw new InvalidOperationException("Попытка получить больше элементов, чем есть в стеке!");
                }

                List<T> _Result = new List<T>();

                for (int i = m_Items.Count - 1; _CountLastItems > 0; _CountLastItems--)
                {
                    _Result.Add(m_Items[i]);
                    i--;
                }

                return _Result;
            }
            //----------------------------------------------------------
        }
        //----------------------------------------------------------
    }
}
