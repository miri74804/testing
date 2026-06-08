using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class Node<T>
    {
        T Value;
        Node<T> Next;
        public void SetValue(T value) => this.Value = value;
        public T GetValue => this.Value;
        public void SetNext(Node<T> node) => this.Next = node;
        public Node<T> GetNext => this.Next;

        public Node(T value, Node<T> next)
        {
            this.Value = value;
            this.Next = next;
        }

        public Node(T value)
        {
            this.Value = value;
        }
        public bool HasNext() => Next != null;
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
