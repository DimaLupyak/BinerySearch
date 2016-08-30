using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySearch
{
    public class BineryTree <T> where T : IComparable
    {

        private Node RootNode { get; set; }

        public bool IsExist(T value)
        {
            if (RootNode == null) return false;
            return RootNode.IsExist(value);
        }

        public void Add(T[] array)
        {
            foreach (var item in array)
            {
                Add(item);
            }
        }

        public void Add(T value)
        {
            if (RootNode == null)
            {
                RootNode = new Node
                {
                    Value = value
                };
            }
            else
                RootNode.Add(value);
        }

        private class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public T Value { get; set; }

            public bool IsExist(T value)
            {
                if (Value.CompareTo(value) == 0)
                    return true;
                if (value.CompareTo(Value) < 0)
                {
                    if (Left == null)
                        return false;
                    else
                        return Left.IsExist(value);
                }
                else
                {
                    if (Right == null)
                        return false;
                    else
                        return Right.IsExist(value);
                }
            }

            public void Add(T value)
            {
                if(value.CompareTo(Value) < 0)
                {
                    if (Left == null)
                    {
                        Left = new Node
                        {
                            Value = value
                        };
                    }
                    else
                        Left.Add(value);
                }
                else
                {
                    if (Right == null)
                    {
                        Right = new Node
                        {
                            Value = value
                        };
                    }
                    else
                        Right.Add(value);
                }
            }
        }
    }
}
