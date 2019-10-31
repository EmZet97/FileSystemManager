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

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public INode GetParent() => parent;

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }

        public void SetParent(INode parent)
        {
            this.parent = parent;
        }
    }
}
