using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria0._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public void RedrawList()
        {
            int number = 1;
            Line.Items.Clear();
            foreach(Lumberjack lumberjack in breakfastLine) { Line.Items.Add(number + ". " + lumberjack.Name);number++; }
            if(breakfastLine.Count == 0) { groupBox1.Enabled = false; NextInLine.Text = ""; }
            else { groupBox1.Enabled = true; Lumberjack currentLumberjack = breakfastLine.Peek();
                NextInLine.Text = currentLumberjack.Name+" has "+ currentLumberjack.FlapjackCount + " flapjacks";
            }
        }
        private void AddLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(lumber.Text));
            lumber.Text = "";
            RedrawList();
        }
        private void AddFlapjack_Click(object sender, EventArgs e)
        {
            Lumberjack.Flapjack food;
            if (Crispy.Checked == true) food = Lumberjack.Flapjack.crispy;
            else if (soggy.Checked == true) food = Lumberjack.Flapjack.soggy;
            else if (browned.Checked == true) food = Lumberjack.Flapjack.browned;
            else food = Lumberjack.Flapjack.banana;
            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)LowMany.Value);
            RedrawList();
        }
        private void NexLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjack();
            NextInLine.Text = "";
            RedrawList();
        }
    }
}
