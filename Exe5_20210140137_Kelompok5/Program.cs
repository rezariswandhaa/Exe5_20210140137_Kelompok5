using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_20210140137_Kelompok5
{
    class Node
    {
        public string nama;
        public Node next;
    }

    class queue
    {
        Node reza, riswandha;
        public queue()
        {
            reza = null;
            riswandha = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            nm = Console.ReadLine();
            newnode.nama = nm;
            newnode.next = null;  
            if (reza == null)
            {
                reza = newnode;
                riswandha = newnode;
                return;
            }
            reza.next = newnode;
            reza = newnode;
        }
        public void delete()
        {
            if (reza == null)
            {
                Console.WriteLine("Queue is Empty!");
                return;
            }
            reza = reza.next;
            if(reza == null)
                riswandha = null; 
        }
        public void display()
        {
            if (reza == null)
            {
                Console.WriteLine("Queue is Empty!");
                return ;
            }
            Node display;
            for (display = reza; display != null; display = display.next)
                Console.WriteLine(display.nama);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
