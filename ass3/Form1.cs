using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Title = " Open";
            File.Filter="Text Document (*.txt)|*.txt|All Files(*.*)|*.*";

            if(File.ShowDialog() ==DialogResult.OK)
            {
                richTextBox1.LoadFile(File.FileName, RichTextBoxStreamType.PlainText);
                this.Text = File.FileName;

                    
            }

        } private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog File = new SaveFileDialog();
            File.Title = " Open";
            File.Filter = "Text Document (*.txt)|*.txt|All Files(*.*)|*.*";

            if (File.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(File.FileName, RichTextBoxStreamType.PlainText);
                this.Text = File.FileName;


            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }


        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ColorDialog font = new ColorDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor= font.Color;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
          
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); 
                }

        private void wrapWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(wrapWordToolStripMenuItem.Checked==true)
            {
                wrapWordToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
            else
            {
                wrapWordToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
        }

        private void highlightTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Yellow;
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Please write something";

        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                toolStripStatusLabel2.Text = "Moving up";
            }
            else
            {
                toolStripStatusLabel2.Text = "";
            }

        }

        private void richTextBox1_CursorChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = Cursor.Position.ToString();
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel4.ForeColor = Color.Aqua;
            toolStripStatusLabel4.Text = " Hello";
        }

        private void richTextBox1_ForeColorChanged(object sender, EventArgs e)
        {
           toolStripStatusLabel5.ForeColor = Color.Blue;
            

          
        }

        private void toolStripStatusLabel5_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel5.BackColor = Color.Red;
            toolStripStatusLabel5.Text = "SAVE YOUR TEXT";

        }
    }
}
