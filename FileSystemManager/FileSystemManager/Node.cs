using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemManager
{
    abstract class Node : INode
    {
        private INode parent;
        private string name;

        public Node()
        {
            name = "Default name";
        }

        public string GetName()
        {
            return this.name;
        }

        public INode GetParent() => parent;

        public bool SetName(string name)
        {
            this.name = name;
            return true;
        }

        public void SetParent(INode parent)
        {
            this.parent = parent;
        }
    }
}
