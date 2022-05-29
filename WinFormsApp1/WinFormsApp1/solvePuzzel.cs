using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static WinFormsApp1.State;

namespace WinFormsApp1
{
    class solvePuzzel
    {

        private void swap2ndheursitc(State cur, ref State child, int newxZero, int newyZero)
        {
            child.matrix = cur.matrix.Clone() as int[,];
            int num1 = cur.matrix[newxZero, newyZero];
            child.matrix[cur.xZero, cur.yZero] = num1;
            child.matrix[newxZero, newyZero] = 0;

            child.xZero = newxZero; child.yZero = newyZero;
            //if(State.size==3)
            child.correctPath = cur.correctPath + num1.ToString() + '|';
            child.depth = cur.depth + 1;
            if (State.type == 'H')
                Hamming(child);
            else if (State.type == 'M')
                Manhatendistance(child);
            child.totalCost = child.depth + child.heursitcValue;

        }
        public PriorityQueue<State, int> notVistedState;
        public Queue<State> queu;
        HashSet<int> visitedState;
        public solvePuzzel()
        {

            visitedState = new HashSet<int>();
            notVistedState = new PriorityQueue<State, int>();
            queu = new Queue<State>();
        }

        public State Bfs(State cur)
        {
            while (queu.Count > 0)
            {
                State temp = queu.Dequeue();
                if (temp.heursitcValue == 0) return temp;               
                visitedState.Add(temp.hash);
                Expand(temp);
            }
            return cur;

        }
        public State Asatr(State cur)
        {

            while (notVistedState.Count > 0)
            {
                State temp = notVistedState.Dequeue();
                if (temp.heursitcValue == 0) return temp;
                
                visitedState.Add(temp.hash);
                Expand(temp);
            }
            return cur;
        }

        void Expand(State cur)
        {

            if (cur.xZero + 1 < State.size)//Down
            {
                State child = new State();
                swap2ndheursitc(cur, ref child, cur.xZero + 1, cur.yZero);

                if (IsInClosed(child.hash) == false)
                {
                    //child.CorrectPath.Add(cur.elements);//Take Copy from list correct path

                    if (State.typeofAlgorithmis == 'A')
                        notVistedState.Enqueue(child, child.totalCost);
                    else if (State.typeofAlgorithmis == 'B')
                        queu.Enqueue(child);
                }
            }
            if (cur.xZero - 1 >= 0)//Up
            {

                State child = new State();
                swap2ndheursitc(cur, ref child, cur.xZero - 1, cur.yZero);

                if (IsInClosed(child.hash) == false)
                {
                    // child.CorrectPath.Add(cur.elements);
                    if (State.typeofAlgorithmis == 'A')
                        notVistedState.Enqueue(child, child.totalCost);
                    else if (State.typeofAlgorithmis == 'B')
                        queu.Enqueue(child);

                }
            }
            if (cur.yZero - 1 >= 0)
            {

                State child = new State();
                swap2ndheursitc(cur, ref child, cur.xZero, cur.yZero - 1);

                if (IsInClosed(child.hash) == false)
                {

                    if (State.typeofAlgorithmis == 'A')
                        notVistedState.Enqueue(child, child.totalCost);
                    else if (State.typeofAlgorithmis == 'B')
                        queu.Enqueue(child);
                }
            }

            if (cur.yZero + 1 < State.size)
            {

                State child = new State();
                swap2ndheursitc(cur, ref child, cur.xZero, cur.yZero + 1);

                if (IsInClosed(child.hash) == false)
                {

                    if (State.typeofAlgorithmis == 'A')
                        notVistedState.Enqueue(child, child.totalCost);
                    else if (State.typeofAlgorithmis == 'B')
                        queu.Enqueue(child);

                }
            }



        }
        bool IsInClosed(int hash)
        {
            if (visitedState.Contains(hash)) return true;
            return false;
        }
        public void Hamming(State state)
        {

            for (int row = 0; row < State.size; row++)
            {
                for (int colum = 0; colum < State.size; colum++)
                {

                    state.hash = state.hash * 31 + state.matrix[row, colum];
                    if (state.matrix[row, colum] == 0)
                        continue;
                    if (State.goolState[state.matrix[row, colum]].row != row || State.goolState[state.matrix[row, colum]].col != colum)
                        state.heursitcValue++;

                }
            }

        }
        public void Manhatendistance(State state)
        {

            for (int i = 0; i < State.size; i++)
            {
                for (int x = 0; x < State.size; x++)
                {
                    state.hash = state.hash * 31 + state.matrix[i, x];
                    if (state.matrix[i, x] == 0) continue;
                    int row = State.goolState[state.matrix[i, x]].row;
                    int colum = State.goolState[state.matrix[i, x]].col;
                    state.heursitcValue += Math.Abs(row - i) + Math.Abs(colum - x);

                }
            }

        }

    }


}
