using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis;
using System.IO;


namespace ParserCSharp
{


    public partial class CSParser : Form
    {
        IEnumerator<NavMessage> listOfNodes;
        Stack<SyntaxNode> expandStack = new Stack<SyntaxNode>();
        ExcelAdapter excel = new ExcelAdapter(Directory.GetCurrentDirectory() + @"\HEllo.xlsx");
        private bool allowContinue = true;
        

        public CSParser()
        {

            InitializeComponent();

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            if (startTb.Text != null && startTb.Text != "") allowContinue = false;
            CSCodeParser parser = new CSCodeParser();
            listOfNodes = parser.Run().GetEnumerator();
            if (listOfNodes == null) NodeTB.Text = "Literal tokens was not found";
            excel.Open();
            Startbtn.Enabled = false;
            Expbtn.Enabled = false;
            Shrinkbtn.Enabled = false;
            Nextbtn.Enabled = true;
            startTb.ReadOnly = true;
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if(!allowContinue)
            {
                while(listOfNodes.MoveNext())
                {
                    var subPath = listOfNodes.Current.fullPath.Substring(Directory.GetCurrentDirectory().Length);
                    var file = subPath.Substring(subPath.LastIndexOf('\\') + 1);
                    if(file == startTb.Text)
                    {
                        allowContinue = true;
                        break;
                    }
                }
            }


            if (listOfNodes.MoveNext())
            {
                var subPath = listOfNodes.Current.fullPath.Substring(Directory.GetCurrentDirectory().Length);
                NodeTB.Text = listOfNodes.Current.node.ToString();
                expandStack.Push(listOfNodes.Current.node);
                lineTb.Text = listOfNodes.Current.line.ToString();

                fileTb.Text = subPath.Substring(subPath.LastIndexOf('\\') + 1);
                moduleTb.Text = subPath.Substring(0, subPath.Length - fileTb.Text.Length);

                methodTb.Text = listOfNodes.Current.method;

            }
            else NodeTB.Text = "Congrats you finished that bullshit";




            Nextbtn.Enabled = false;
            Expbtn.Enabled = true;
            Shrinkbtn.Enabled = true;
            Savebtn.Enabled = true;
            passBtn.Enabled = true;
        }

        private void Expbtn_Click(object sender, EventArgs e)
        {
            SyntaxNode current = default(SyntaxNode);
            if (expandStack.Count == 0)
            {
                current = listOfNodes.Current.node;
                expandStack.Push(current);
                NodeTB.Text = current.ToString();
            }
            else
            {
                current = expandStack?.Peek();


                if (current?.Parent != null)
                {
                    expandStack.Push(current.Parent);
                    NodeTB.Text = current.Parent.ToString();
                }
                else NodeTB.Text = "Empty parent";
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            expandStack.Clear();
            Nextbtn.Enabled = true;
            Expbtn.Enabled = false;
            Shrinkbtn.Enabled = false;
            Savebtn.Enabled = false;
            passBtn.Enabled = false;

            excel.write(moduleTb.Text, fileTb.Text, methodTb.Text, lineTb.Text, NodeTB.Text);

            NodeTB.Text = null;
        }

        private void Shrinkbtn_Click(object sender, EventArgs e)
        {
            if (expandStack.Count > 0)
            {
                var current = expandStack?.Pop();
                if (current != null)
                    NodeTB.Text = current.ToString();
            }
            else NodeTB.Text = "Can not Shrink";
        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            expandStack.Clear();
            Nextbtn.Enabled = true;
            Expbtn.Enabled = false;
            Shrinkbtn.Enabled = false;
            Savebtn.Enabled = false;
            passBtn.Enabled = false;

            NodeTB.Text = null;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            excel.close();
        }

        private void CSParser_FormClosed(object sender, FormClosedEventArgs e)
        {
            excel.close();
        }



        private void CSParser_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            switch (e.KeyCode)
            {
                case Keys.Up: Expbtn_Click(sender, e); break;
                case Keys.Down: Shrinkbtn_Click(sender, e); break;
                case Keys.Left: Savebtn_Click(sender, e); break;
                case Keys.Right: Nextbtn_Click(sender, e); break;
               // case Keys.F: passBtn_Click(sender, e); break;
            }


        }

        private void CSParser_Load(object sender, EventArgs e)
        {

        }
    }
}
