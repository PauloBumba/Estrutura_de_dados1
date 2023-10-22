using System;
using Arvore_De_busca;
class Program {
    static void Main(string[] args){
        BinaryTree tree = new BinaryTree();
        tree.insert(30);
        tree.insert(20);
        tree.insert(3);
        tree.insert(2);
        tree.insert(80);
        tree.Pre_order(tree.root);
        tree.Orden(tree.root);
        tree.Pois_Order(tree.root);
        Console.ReadLine();
    }
}