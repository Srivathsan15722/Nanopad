using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                // Toggle the bold style on/off
                FontStyle fontStyle = richTextBox1.SelectionFont.Style;

                if (richTextBox1.SelectionFont.Bold)
                {
                    fontStyle &= ~FontStyle.Bold; // Remove bold style
                }
                else
                {
                    fontStyle |= FontStyle.Bold; // Add bold style
                }

                // Apply the new font style to the selected text
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, fontStyle);
            }
        }
    }
}
