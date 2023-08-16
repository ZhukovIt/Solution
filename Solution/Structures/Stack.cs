using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Structures
{
    public sealed class Stack<T>
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

            List<T> _NewItems = new List<T>();

            for (int i = 0; i < m_Items.Count; i++)
            {
                if (i != m_Items.Count - 1)
                {
                    _NewItems.Add(m_Items[i]);
                }
                else
                {
                    T _LastItem = m_Items[i];

                    m_Items = _NewItems;

                    return _LastItem;
                }
            }

            throw new NotImplementedException("Метод Pop не должен был дойти до данной точки!");
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
    }
}
