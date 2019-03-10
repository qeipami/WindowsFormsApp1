using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menucommand(sender as ToolStripItem);
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menucommand(sender as ToolStripItem);

        }
        private void apriForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menucommand(sender as ToolStripItem);

        }
        private void apriForm5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menucommand(sender as ToolStripItem);

        }
        private void menucommand(ToolStripItem toolstripitem)
        {
            Form myform;
            switch (toolstripitem.Text)
            {
                case "Apri Form 1":
                    myform = new Form1();
                    myform.ShowDialog();
                    break;
                case "Apri Form 3":
                    myform = new Form3();
                    myform.ShowDialog();
                    break;
                case "Apri Form 5":
                    myform = new Form5();
                    myform.ShowDialog();
                    break;
                case "Esci":
                    this.Dispose();
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }


    }
}
