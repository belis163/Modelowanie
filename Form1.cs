using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumulacja
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int number_of_cells = 0;
        int number_of_steps = 0;
        int BC = 0;
        int rule = 0;
        bool[] binRule = new bool[8];
        List<Cell[]> cellList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            try
            {
                number_of_cells = int.Parse(number_of_cells_text_box.Text);
                number_of_steps = int.Parse(number_of_steps_text_box.Text);
                rule = int.Parse(rule_combo_box.Text);

                if (bc_combo_box.Text == "periodyczne")
                {
                    BC = 1;
                }
                else if (bc_combo_box.Text == "pochlaniajace")
                {
                    BC = 2;
                }
                else if (bc_combo_box.Text == "odbijajace")
                {
                    BC = 3;
                }

                String binaryRule = Convert.ToString(rule, 2);
                int positionIndex = 0;
                int index;

                for (index = 0; index < (8 - binaryRule.Length); index++)
                {
                    binRule[index] = false;
                }
                while (positionIndex < binaryRule.Length)
                {
                    binRule[positionIndex + (8 - binaryRule.Length)] = Convert.ToBoolean(binaryRule[positionIndex] - '0');
                    positionIndex++;
                }

                Cell[] cells = new Cell[number_of_cells];
                for (int i = 0; i < number_of_cells; i++)
                {
                    cells[i] = new Cell();
                }
                cells[number_of_cells / 2].setCellState(true);

                cellList = new List<Cell[]>();
                cellList.Add(cells);

                for (int i = 1; i < number_of_steps; i++)
                {
                    cellList.Add(new Cell[number_of_cells]);
                    for (int j = 0; j < number_of_cells; j++)
                    {
                        cellList[i][j] = new Cell();
                    }
                }

                switch (BC)
                {
                    case 1:
                        {
                            calculatePeriodical(cellList, binRule);
                            break;
                        }
                    case 2:
                        {
                            cells[number_of_cells - 1].setCellState(true);
                            cells[0].setCellState(true);
                            calculateAbsorbing(cellList, binRule);
                            break;
                        }
                    case 3:
                        {
                            cells[number_of_cells - 1].setCellState(true);
                            cells[0].setCellState(true);
                            calculateBouncing(cellList, binRule);
                            break;
                        }
                    default:
                        MessageBox.Show("ZobaCoJes");
                        break;
                }
                
                drawCells(cellList);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

           /* number_of_cells = 0;
            number_of_steps = 0;
            BC = 0;
            rule = 0;*/

        }
        

        private void calculatePeriodical(List<Cell[]> stepsList, bool[] binRule)
        {
            bool before, center, after;

            for(int i=1; i< number_of_steps; i++)
            {
                for (int j = 0; j < number_of_cells; j++)
                {
                    if (j == 0)
                    {
                        before = stepsList[i - 1][number_of_cells - 1].getCellState();
                        center = stepsList[i - 1][j].getCellState();
                        after = stepsList[i - 1][j + 1].getCellState();
                    }
                    else if (j == number_of_cells - 1)
                    {
                        before = stepsList[i - 1][j - 1].getCellState();
                        center = stepsList[i - 1][j].getCellState();
                        after = stepsList[i - 1][0].getCellState();
                    }
                    else
                    {
                        before = stepsList[i - 1][j - 1].getCellState();
                        center = stepsList[i - 1][j].getCellState();
                        after = stepsList[i - 1][j + 1].getCellState();
                    }

                    if ((before == true) && (center == true) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[0]);
                    }
                    else if ((before == true) && (center == true) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[1]);
                    }
                    else if ((before == true) && (center == false) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[2]);
                    }
                    else if ((before == true) && (center == false) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[3]);
                    }
                    else if ((before == false) && (center == true) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[4]);
                    }
                    else if ((before == false) && (center == true) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[5]);
                    }
                    else if ((before == false) && (center == false) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[6]);
                    }
                    else if ((before == false) && (center == false) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[7]);
                    }
                }
            }
        }

        private void calculateAbsorbing(List<Cell[]> stepsList, bool[] binRule)
        {
            bool before, center, after;

            for (int i = 1; i < number_of_steps; i++)
            {
                for (int j = 0; j < number_of_cells; j++)
                {
                    if (j == 0)
                    {
                        before = true;
                        center = stepsList[i - 1][j].getCellState();
                        after = stepsList[i - 1][j + 1].getCellState();
                    }
                    else if (j == number_of_cells - 1)
                    {
                        before = stepsList[i - 1][j - 1].getCellState();
                        center = stepsList[i - 1][j].getCellState();
                        after = stepsList[i - 1][0].getCellState();
                    }
                    else
                    {
                        before = stepsList[i - 1][j - 1].getCellState();
                        center = stepsList[i - 1][j].getCellState();
                        after = true;
                    }

                    if ((before == true) && (center == true) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[0]);
                    }
                    else if ((before == true) && (center == true) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[1]);
                    }
                    else if ((before == true) && (center == false) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[2]);
                    }
                    else if ((before == true) && (center == false) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[3]);
                    }
                    else if ((before == false) && (center == true) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[4]);
                    }
                    else if ((before == false) && (center == true) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[5]);
                    }
                    else if ((before == false) && (center == false) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[6]);
                    }
                    else if ((before == false) && (center == false) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[7]);
                    }
                }
            }
        }

        private void calculateBouncing(List<Cell[]> stepsList, bool[] binRule)
        {
            bool before, center, after;

            for (int i = 1; i < number_of_steps; i++)
            {
                for (int j = 0; j < number_of_cells; j++)
                {
                    if (j == 0)
                    {
                        before = !stepsList[i - 1][j].getCellState();
                        center = stepsList[i - 1][j].getCellState();
                        after = stepsList[i - 1][j + 1].getCellState();
                    }
                    else if (j == number_of_cells - 1)
                    {
                        before = stepsList[i - 1][j - 1].getCellState();
                        center = stepsList[i - 1][j].getCellState();
                        after = stepsList[i - 1][0].getCellState();
                    }
                    else
                    {
                        before = stepsList[i - 1][j - 1].getCellState();
                        center = stepsList[i - 1][j].getCellState();
                        after = !stepsList[i - 1][j].getCellState();
                    }

                    if ((before == true) && (center == true) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[0]);
                    }
                    else if ((before == true) && (center == true) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[1]);
                    }
                    else if ((before == true) && (center == false) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[2]);
                    }
                    else if ((before == true) && (center == false) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[3]);
                    }
                    else if ((before == false) && (center == true) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[4]);
                    }
                    else if ((before == false) && (center == true) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[5]);
                    }
                    else if ((before == false) && (center == false) && (after == true))
                    {
                        stepsList[i][j].setCellState(binRule[6]);
                    }
                    else if ((before == false) && (center == false) && (after == false))
                    {
                        stepsList[i][j].setCellState(binRule[7]);
                    }
                }
            }
        }

        private void drawCells(List<Cell[]> stepsList)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(this.pictureBox1.Image);
            SolidBrush solidBrush = new SolidBrush(Color.Aqua);

            float PBWidtgh= (float)pictureBox1.Width / (float)number_of_cells;
            float PBHeight = (float)pictureBox1.Height / (float)number_of_steps;

            float x = 0;
            float y = 0;

            for(int i=0; i < number_of_steps; i++)
            {
                for(int j = 0; j < number_of_cells; j++)
                {
                    if(stepsList[i][j].getCellState() == true)
                    {
                        solidBrush.Color = Color.Pink;
                    }
                    else
                    {
                        solidBrush.Color = Color.Aqua;
                    }

                    graphics.FillRectangle(solidBrush, x, y, PBWidtgh, PBHeight);
                    x = x + PBWidtgh;
                }
                x = 0;
                y = y + PBHeight;
            }

        }


    }    
}

