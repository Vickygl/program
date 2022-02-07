
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{


    class Table
    {
        private int w = 0;
        private int h = 0;

        public Table(int width, int height)
        {
            if (width >= 0) this.w = width;
            if (height >= 0) this.h = height;
        }
        public void ShowData() => Console.WriteLine("Height - {0} cm, width - {1} cm", h, w);
    }
    class TableDim
    {
        static void Main(string[] args)
        {
            Table[] arr = new Table[10];
            Random value = new Random();


            for (int i = 0; i < 10; i++)
                arr[i] = new Table(value.Next(50, 200), value.Next(50, 200));
            foreach (var i in arr)
                i.ShowData();
        }
    }

}