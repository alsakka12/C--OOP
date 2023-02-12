using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Point_test {
        // Data 
        private int x;
        private int y;
        private string name;
        // constructor 

        public Point_test() {
            x = 0;
            y = 0;
            name = "p1";

            System.Windows.Forms.MessageBox.Show("hello" + name + "(" + x + "," + y + ")");
        }
        public Point_test(int x, int y, string name) {
            this.x = x;
            this.y = y;
            this.name = name;
            System.Windows.Forms.MessageBox.Show("hi" + name + "(" + x + ","  +y + ")");

        } } }
