using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arvore_De_busca
{
    public class BinaryTree
    {
        public NodeTree root;
        public BinaryTree(int value)
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
        public void Remove (int value){
            root=Removerec(root,value);
            return;
        }
        public NodeTree Removerec(NodeTree root, int value)
        {
            if(root==null){
                Console.Write("Stack overflow 5 ")
                return;
            }
            if(value<root.Value){
                root.Left=Removerec(root.Left,value);
                
            }
            else if(value>root.Value){
                root.Right=Removerec(root.Right,value);
            }
            else
            {
                if(root.Left==null && root.Right==null){
                    return null;
                }
                else if (root.Left==null){
                    return null;
                    
                }
                else if (root.Right==null){
                    return null;
                    
                }
                root.Value=MinValue(root.Right);
                root.Right=Removerec(root.Right,root.Value);
                
                private int MinValue(NodeTree root){
                    while(root.Left!=null){
                        MinValue=root.Left.Value;
                        root=root.Left;
                    }
                    return MinValue
                }
            }

            return root
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
                Orden(root.Right);
                Console.Write(root.Value + " ");
                Orden(root.Left);
                
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
