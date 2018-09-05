using System;
using System.Drawing;
using System.Windows.Forms;

namespace Random_Maze_Generator
{
    public partial class Form1 : Form
    {
        int row, col;
        bool invalid;
        int cellWidth, cellCount, dir;
        Graph[,] theGraph;
        Stack theStack;
        Random rand;
        Graphics g;
        Pen thePen,whitePen;
        Brush theBrush,white;
        int x1, y1, x2, y2;
        int poppedVal;
        int flag;
        Panel thePanel;

        public Form1()
        {
            InitializeComponent();

            cellWidth = 20;
            theStack = new Stack();
            rand = new Random();
            cellCount = 0;
            theBrush = new SolidBrush(Color.Blue);
            thePen = new Pen(theBrush);
            white = new SolidBrush(Color.White);
            whitePen = new Pen(white);
        }

        private void btn_genMaze_Click(object sender, EventArgs e)
        {
            invalid = false;
            flag = 0;

            try
            {
                row = Convert.ToInt32(tb_height.Text.Trim());
                col = Convert.ToInt32(tb_width.Text.Trim());
                if (row > 30 || col > 30 || row < 1 || col < 1)
                {
                    MessageBox.Show("Width or height cannot be less than 1 or greater than 30");
                    throw new Exception();
                }
            }
            catch (Exception E) { invalid = true; }

            if (tb_width.Text != "" && tb_height.Text != "" && invalid == false)
            {
                removeCurrentControls();
                BackColor = Color.White;

                thePanel = new Panel();
                thePanel.Width = 620;
                thePanel.Height = 620;
                thePanel.Location = new Point(5, 5);
                thePanel.Paint += new PaintEventHandler(thePanel_Paint);

                Controls.Add(thePanel);
                Width = (col + 2) * cellWidth;
                Height = (row + 5) * cellWidth;

                btn_back.Visible = true;
                btn_back.Location = new Point(row/2, Height - 80);

                initializeGraph();
                g = thePanel.CreateGraphics();
            }
        }

        private void initializeGraph()
        {
            theGraph = new Graph[row, col];

            for (int i = 0; i < theGraph.GetLength(0); i++)
            {
                for (int j = 0; j < theGraph.GetLength(1); j++)
                {
                    theGraph[i, j] = new Graph();
                    theGraph[i, j].visited = false;
                    theGraph[i, j].up = theGraph[i, j].down = theGraph[i, j].left = theGraph[i, j].right = false;
                    theGraph[i, j].cellNumber = ++cellCount;
                }
            }
        }

        public void thePanel_Paint(object sender, PaintEventArgs e)
        {
            x1 = 0;
            y1 = 0;
            x2 = cellWidth;
            y2 = 0;

            for (int i = 0; i < theGraph.GetLength(0) + 1; i++)
            {
                for (int j = 0; j < theGraph.GetLength(1); j++)
                {
                    if (flag == 0) g.DrawLine(thePen, x1, y1, x2, y2);
                    x1 = x2;
                    x2 += cellWidth;
                }
                y1 = y2 += cellWidth;
                x1 = 0;
                x2 = cellWidth;
            }

            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = cellWidth;

            for (int i = 0; i < theGraph.GetLength(0); i++)
            {
                for (int j = 0; j < theGraph.GetLength(1) + 1; j++)
                {
                    if (flag == 0) g.DrawLine(thePen, x1, y1, x2, y2);
                    x1 = x2 += cellWidth;
                }
                y1 = y2;
                y2 += cellWidth;
                x1 = x2 = 0;
            }

            if (flag == 0) traverseGraph(0, 0, 1);
            flag++;
            btn_back.Enabled = true;
        }

        private void traverseGraph(int r, int c, int cellNumber)
        {
            theStack.push(cellNumber);
            theGraph[r, c].visited = true;

            do
            {
                if (theGraph[r, c].up == true && theGraph[r, c].down == true && theGraph[r, c].left == true && theGraph[r, c].right == true)
                {
                    poppedVal = theStack.pop();
                    return;
                }
                else
                {
                    dir = rand.Next(1, 5);
                    try
                    {
                        if (dir == 1 && theGraph[r, c].up == false)
                        {
                            theGraph[r, c].up = true;
                            if (theGraph[r - 1, c].visited == false)
                            {
                                x1 = (c * cellWidth) + 1;
                                y1 = y2 = (r * cellWidth);
                                x2 = x1 + (cellWidth - 2);
                                g.DrawLine(whitePen, x1, y1, x2, y2);
                                traverseGraph(r - 1, c, theGraph[r - 1, c].cellNumber);
                            }
                        }
                        else if (dir == 2 && theGraph[r, c].right == false)
                        {
                            theGraph[r, c].right = true;
                            if (theGraph[r, c + 1].visited == false)
                            {
                                x1 = x2 = (c + 1) * cellWidth;
                                y1 = (r * cellWidth) + 1;
                                y2 = y1 + (cellWidth - 2);
                                g.DrawLine(whitePen, x1, y1, x2, y2);
                                traverseGraph(r, c + 1, theGraph[r, c + 1].cellNumber);
                            }
                        }
                        else if (dir == 3 && theGraph[r, c].down == false)
                        {
                            theGraph[r, c].down = true;
                            if (theGraph[r + 1, c].visited == false)
                            {
                                x1 = (c * cellWidth) + 1;
                                y1 = y2 = (r + 1) * cellWidth;
                                x2 = x1 + (cellWidth - 2);
                                g.DrawLine(whitePen, x1, y1, x2, y2);
                                traverseGraph(r + 1, c, theGraph[r + 1, c].cellNumber);
                            }
                        }
                        else if (dir == 4 && theGraph[r, c].left == false)
                        {
                            theGraph[r, c].left = true;
                            if (theGraph[r, c - 1].visited == false)
                            {
                                x1 = x2 = c * cellWidth;
                                y1 = (r * cellWidth) + 1;
                                y2 = y1 + (cellWidth - 2);
                                g.DrawLine(whitePen, x1, y1, x2, y2);
                                traverseGraph(r, c - 1, theGraph[r, c - 1].cellNumber);
                            }
                        }
                    }
                    catch (Exception e) { }
                }
            } while (true);
        }

        private void removeCurrentControls()
        {
            lbl_name.Visible = false;
            lbl_logo.Visible = false;
            lbl_width.Visible = false;
            lbl_height.Visible = false;
            lbl_license.Visible = false;
            tb_width.Visible = false;
            tb_height.Visible = false;
            btn_genMaze.Visible = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Controls.Remove(thePanel);
            lbl_name.Visible = true;
            lbl_logo.Visible = true;
            lbl_width.Visible = true;
            lbl_height.Visible = true;
            lbl_license.Visible = true;
            tb_width.Visible = true;
            tb_height.Visible = true;
            btn_genMaze.Visible = true;
            Width = 329;
            Height = 497;
            BackColor = Color.FromArgb(255, 128, 0);
            btn_back.Visible = false;
            btn_back.Enabled = false;
        }
    }

    class Graph
    {
        public bool visited, up, down, left, right;
        public int cellNumber;
    }

    class Stack
    {
        public int[] theStack;
        int top;

        public Stack()
        {
            top = 0;
            theStack = new int[10];
        }

        public void push(int num)
        {
            if (top < theStack.Length) theStack[top++] = num;

            else
            {
                int[] temp = new int[top + 10];
                for (int i = 0; i < theStack.Length; i++) temp[i] = theStack[i];

                theStack = temp;
                theStack[top++] = num;
            }
        }

        public int pop()
        {
            if (top > 0) return theStack[--top];

            else return -1;
        }
    }
}