using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Arvore_Binaria
{
    public class BinaryTree
    {
        public NodeTree root;
        public BinaryTree()
        {
            root=null;
        }
        public void insert(int value){
            root=InsertRec(root,value);
            return;
        }
        private NodeTree InsertRec(NodeTree root,int value)
        {
            if (root==null)
            {
                root=new NodeTree(value);
            }
            else{
                if (value<root.Value)
                {
                    root.Left=InsertRec(root.Left,value);
                }
                else if (value>root.Value)
                {
                     root.Right=InsertRec(root.Right,value);
                }
            }
            return root;
        }
        public void Pre_order(NodeTree root)
        {
            if (root!=null)
            {
                Console.Write(root.Value + " ");
                Pre_order(root.Left);
                Pre_order(root.Right);
            }
        }
        
        public void Orden(NodeTree root)
        {
            if (root!=null)
            {
                Orden(root.Left);
                Console.Write(root.Value + " ");
                Orden(root.Right);
                
            }
        }
        
        public void Pois_Order(NodeTree root)
        {
            if (root!=null){
                
                Pre_order(root.Left);
                Pre_order(root.Right);
                Console.Write(root.Value + " ");
            }
        }

}
}
    