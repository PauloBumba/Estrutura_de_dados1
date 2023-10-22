using System;
using Arvore_Binaria;


class program{
    static void Main(string[] args){
        BinaryTree tree = new BinaryTree();
        tree.insert(100);
        tree.insert(20);
        tree.insert(40);
        tree.insert(90);
        tree.insert(890);
        tree.insert(1230);
        tree.insert(800);

        tree.Pre_order(tree.root);
        Console.WriteLine();
        tree.Orden(tree.root);
         Console.WriteLine();
        tree.Pois_Order(tree.root);

        Console.ReadLine();
    }
}