using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsApp
{
    internal class Box<T>
    {
        private T _content;

        public Box(T initialValue)
        {
            _content = initialValue;

        }

        public void UpdateContent(T newContent)
        {
            _content = newContent;
            Console.WriteLine($"Updated content to {_content}");
        }

        public T GetContent()
        { 
            return _content;
        }
    }
}
