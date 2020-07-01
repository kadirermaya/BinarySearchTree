using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(40);
            bst.Add(35);
            bst.Add(50);
            bst.Add(10);
            bst.Add(5);
            bst.Add(55);
            bst.Add(60);
            bst.Add(43);
            bst.Add(53);
            bst.Add(7);


            bool returned = bst.Search(53);

            Console.WriteLine(returned);

            Console.ReadLine();



            //bool found = bst.Search(12);
        }
    }
}
