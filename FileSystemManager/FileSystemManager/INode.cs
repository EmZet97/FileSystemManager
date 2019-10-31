using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemManager
{
    interface INode
    {
        bool SetName(string name);        
        string GetName();

        //Set reference to parent node
        void SetParent(INode parent);

        //Get reference to parent node
        INode GetParent();


    }
}
