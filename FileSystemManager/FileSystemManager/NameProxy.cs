using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemManager
{
    class NameProxy : INode
    {
        private INode node;
        private File.FileType type;

        public NameProxy(File.FileType node_type)
        {
            switch (node_type){
                        case File.FileType.File:
                            node = new Directory();
                            break;

                        case File.FileType.Directory:
                            node = new File();
                            break;
                    }
            type = node_type;
        }

        public File.FileType GetNodeType()
        {
            return type;
        }
        public string GetName()
        {
            return node.GetName();
        }

        public INode GetParent()
        {
            return node.GetParent();
        }

        public bool SetName(string name)
        {
            if (name.Length > 0)
            {
                bool match = name.IndexOfAny(new char[] { '*', '&', '#', '/', '\\', '|', '=', '+', '?', '!', '^', '-' }) != -1;
                if (!match)
                {
                    //If new name is correct
                    node.SetName(name);
                    return true;
                }
            }
            return false;
        }

        public void SetParent(INode parent)
        {
            node.SetParent(parent);
        }
    }
}
