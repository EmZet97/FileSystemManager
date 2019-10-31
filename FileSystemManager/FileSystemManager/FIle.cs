using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemManager
{
    class File : Node
    {
        private string content;

        public void Print()
        {
            Console.WriteLine(content);
        }

        public void Write(string content)
        {
            this.content = content;
        }

    }
}
