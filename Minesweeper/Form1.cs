using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        private bool gameInitialised = false;
        private int gridSize = 0;
        private readonly Random random = new Random();
        List<int> mineIndexes = new List<int>();
        string[,] internalMap;
        private int nodeDimensions;
        private int numOfMines;
        private int gridDimension;
        private Solver solver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AutoStart_Click(object sender, EventArgs e)
        {
            WipeGrid();
            DecideMines();
            solver = new Solver(internalMap);
            InitGrid();
        }

        private void InitGrid()
        {      
            for (int i = 0; i < gridSize; i++)
            {
                Button gridNode = new Button();
                gridNode.Click += this.Button_Clicked;
                gridNode.Size = new System.Drawing.Size(nodeDimensions, nodeDimensions);
                gridNode.Tag = mineIndexes.Contains(i);
                gridNode.Name = "Node_" + i.ToString();
                gridNode.Text = solver.GetMineValue(i);
                gridNode.UseVisualStyleBackColor = true;
                internalMap[i / gridDimension, i % gridDimension] = gridNode.Tag.ToString();
                Grid.Controls.Add(gridNode);
            }
            gameInitialised = true;
        }

        private void DecideMines()
        { 
            mineIndexes.Clear();
            for (int i = 0; i < numOfMines; i++)
            {
                int n = random.Next(0, gridSize - 1);
                mineIndexes.Add(n);
                internalMap[n / gridDimension, n % gridDimension] = "True";
            }
        }

        private void WipeGrid()
        {
            Grid.Controls.Clear();
        }

        private void GridSize_TextChanged(object sender, EventArgs e)
        {
            if (GridSizeText.Text != "")
            {
                int temp = Int32.Parse(GridSizeText.Text);
                if (Math.Sqrt(temp) % 1 == 0)
                {
                    gridSize = temp;
                    nodeDimensions = Grid.Size.Height / ((int)Math.Sqrt(gridSize) + 1);
                    numOfMines = (int)Math.Floor((float)gridSize / 5);
                    gridDimension = (int)Math.Sqrt(gridSize);
                    internalMap = new string[gridDimension, gridDimension];
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Debug.WriteLine(btn);
            }
        }
    }
}
