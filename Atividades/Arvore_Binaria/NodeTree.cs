using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvore_Binaria
{
    public class NodeTree
    {
        public  int Value;
        public NodeTree Left{get;set;}
        public NodeTree Right{get;set;}
        public NodeTree(int value){
            Left=null;
            Right=null;
            Value=value;
        }

    }
}