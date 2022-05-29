using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Data;

using System.Drawing;
using System.ComponentModel;
using static System.Windows.Forms.AxHost;
using static WinFormsApp1.solvePuzzel;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        public class Coordinate
        {
            public int row;
            public int col;
        };
        int[,] copyMatrix;
        public  int postionX, postionY;
        public  int sizeOfMatrix;
        public  int[,] getMatrix(string path)
        {
            List<string> file = File.ReadAllLines(path).ToList();
            sizeOfMatrix = int.Parse(file[0]);
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int row = 0, col;
            for (int x = 1; x < file.Count; x++)
            {
                col = 0;
                if (file[x] == "") continue;
                foreach (string val in file[x].Split(" "))
                {
                    if (val == "") continue;
                    matrix[row, col] = int.Parse(val);
                    if (int.Parse(val) == 0)
                    {
                        postionX = row;
                        postionY = col;
                    }
                    col++;


                }
                row++;


            }
            if(sizeOfMatrix==3)
            print(matrix, sizeOfMatrix);
            return matrix;
        }
         List<int> number;
         State state;
         Dictionary<int, Coordinate> getGoolState(int[,] matrix)
        {
            var goolState = new Dictionary<int, Coordinate>();
            number = new List<int>();
            int counter = 1;
            // string elements = string.Empty;
            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int colum = 0; colum < sizeOfMatrix; colum++)
                {
                    number.Add(matrix[row, colum]);
                    if (counter == sizeOfMatrix * sizeOfMatrix)
                        counter = 0;
                    Coordinate coordinate = new Coordinate();
                    coordinate.row = row;
                    coordinate.col = colum;
                    goolState.Add(counter, coordinate);
                    counter++;
                }
            }

            return goolState;
        }
        void print(int[,] matrix,int size)
        {
            int row = 0, col = 0;
            int[] y = { 14, 14, 14,123,123,123,215,215,215 };
            int[] x = { 14, 116, 225, 14, 116, 225, 14, 116, 225 };
            for(int i=0;i<x.Length;i++)
            {
                foreach (Button button in panel1.Controls)
                {
                    button.Enabled = true;
                    if (button.Location.X == x[i] && button.Location.Y== y[i])
                    {
                        button.BackgroundImage = Image.FromFile($"{matrix[row, col]}.JPG");
                        col++;
                        if (col == size)
                        {
                            row++;
                            col = 0;
                        }
                        break;
                    }
                   

                }

            }
            

        }
        
         void printPath(int[,] matrix,ref State state,int num)
        {

                         
               
                if (state.xZero - 1 >= 0 && matrix[state.xZero - 1, state.yZero] == num)
                {

                    int num1 = matrix[state.xZero - 1, state.yZero];
                    matrix[state.xZero, state.yZero] = num1;
                    matrix[state.xZero - 1, state.yZero] = 0;
                    state.xZero = state.xZero - 1;
                    print(matrix,State.size);

                }
                else if (state.xZero + 1 < sizeOfMatrix && matrix[state.xZero + 1, state.yZero] == num)
                {

                    int num1 = matrix[state.xZero + 1, state.yZero];
                    matrix[state.xZero, state.yZero] = num1;
                    matrix[state.xZero + 1, state.yZero] = 0;
                    state.xZero = state.xZero + 1;
                    print(matrix, State.size);

                }
                else if (state.yZero + 1 < sizeOfMatrix && matrix[state.xZero, state.yZero + 1] == num)
                {

                    int num1 = matrix[state.xZero, state.yZero + 1];
                    matrix[state.xZero, state.yZero] = num1;
                    matrix[state.xZero, state.yZero + 1] = 0;
                    state.yZero = state.yZero + 1;
                    print(matrix, State.size);


                }
                else if (state.yZero - 1 >= 0 && matrix[state.xZero, state.yZero - 1] == num)
                {

                    int num1 = matrix[state.xZero, state.yZero - 1];
                    matrix[state.xZero, state.yZero] = num1;
                    matrix[state.xZero, state.yZero - 1] = 0;
                    state.yZero = state.yZero - 1;
                    print(matrix, State.size);

                }
               
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {

        }

        private void threeteen_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fourteen_Click(object sender, EventArgs e)
        {

        }

        private void fiveteen_Click(object sender, EventArgs e)
        {

        }

        private void six_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {

        }

        private void three_Click(object sender, EventArgs e)
        {

        }

        private void four_Click(object sender, EventArgs e)
        {

        }

        private void five_Click(object sender, EventArgs e)
        {

        }
        int counter = 0;
        private void solve_Click(object sender, EventArgs e)
        {
            if (State.size == 3)
            {
                string []num = state.correctPath.Split("|");
                
                if (counter < num.Length && num[counter]!="")
                printPath(copyMatrix, ref state,int.Parse(num[counter]));
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Stopwatch stopwatch = new Stopwatch();
            state = new State();
            try
            {
           
            state.matrix = getMatrix(file_name.Text.ToString());
            }
            catch(Exception ex)
            {                
                minute.Text = "";
                sec.Text = "";
                millisec.Text = "";
                moves.Text = "";
                path.Text = "";
                solvable.Text = "";
                MessageBox.Show("Invalid File Name!!");
                return;
            }
           
            State.goolState = getGoolState(state.matrix);

            Checksolvable checksolvable = new Checksolvable();
            if (checksolvable.Check_puzz(sizeOfMatrix, number, postionX + 1)&&(hamming.Checked||manhattan.Checked)&&(A_star.Checked||bfs.Checked))
            {
                solvePuzzel solvePuzzel = new solvePuzzel();
                copyMatrix= state.matrix;
                State.size = sizeOfMatrix;
                state.xZero = postionX;
                state.yZero = postionY;
                state.totalCost = state.heursitcValue;

                if (hamming.Checked)
                {
                    State.type = 'H';
                    solvePuzzel.Hamming(state);
                }
                else if (manhattan.Checked)
                {
                    State.type = 'M';
                    solvePuzzel.Manhatendistance(state);
                }

                if (A_star.Checked)
                {
                    State.typeofAlgorithmis = 'A';
                    solvePuzzel.notVistedState.Enqueue(state, state.totalCost);
                    stopwatch.Start();
                    state = solvePuzzel.Asatr(state);

                }
                else if (bfs.Checked)
                {
                    State.typeofAlgorithmis = 'B';
                    solvePuzzel.queu.Enqueue(state);
                    stopwatch.Start();
                    state = solvePuzzel.Bfs(state);

                }
                stopwatch.Stop();
                solvable.Text = "Puzzle Can be Solvable";
                minute.Text = stopwatch.Elapsed.Minutes.ToString();
                sec.Text = stopwatch.Elapsed.Seconds.ToString();
                millisec.Text = stopwatch.Elapsed.Milliseconds.ToString();               
                moves.Text = state.depth.ToString();
                path.Text = state.correctPath;
                state.xZero = postionX;
                state.yZero = postionY;

            }

            else
            {
                minute.Text = "";
                sec.Text = "";
                millisec.Text = "";
                moves.Text = "";
                path.Text = "";
                solvable.Text = "Puzzle Can't be Solvable";
            }

        }
    }
}