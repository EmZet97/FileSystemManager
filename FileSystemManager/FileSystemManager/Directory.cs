using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemManager
{
    class Directory : Node
    {
        private List<INode> child_nodes;
        //Add file or directory to child structure
        public void AddChildNode(INode element)
        {
            if(!child_nodes.Contains(element))
                child_nodes.Add(element);
        }

        public void RemoveChildNode(INode element)
        {
            child_nodes.Remove(element);
        }

        public void RemoveChildNode(int index)
        {
            if(index >= 0 && index < child_nodes.Count)
                child_nodes.RemoveAt(index);
        }

        public void MoveNode(INode node, INode to_node)
        {
            node.SetParent(to_node);
        }
    }
}
