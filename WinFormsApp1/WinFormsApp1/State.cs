using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp1.Form1;


namespace WinFormsApp1
{
    class State
    {

        public static char type;
        public static char typeofAlgorithmis;
        public static int size;
        public int xZero, yZero;
        public static Dictionary<int, Coordinate> goolState;
        public int[,] matrix;
        public int heursitcValue = 0, totalCost, depth = 0;
        public string correctPath;
        public int hash = 1;

    }
}
