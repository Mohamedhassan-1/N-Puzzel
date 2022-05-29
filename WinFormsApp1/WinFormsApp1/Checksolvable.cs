using System;
using System.Collections.Generic;
using System.Text;
namespace WinFormsApp1
{
    class Checksolvable
    {

        public Boolean Check_puzz(int size, List<int> number, int BlankPOstion)
        {

            int inversioCount = getInversion(number, size);
            if ((size % 2 != 0 && inversioCount % 2 == 0) || ((size % 2 == 0 && inversioCount % 2 == 0 && BlankPOstion % 2 == 0)) || ((size % 2 == 0 && inversioCount % 2 != 0 && BlankPOstion % 2 != 0)))
                return true;
            return false;

        }
        private int getInversion(List<int> number, int size)
        {
            int inversionCount = 0;
            for (int i = 0; i < number.Count - 1; i++)
            {
                for (int x = i; x < number.Count; x++)
                {
                    if (number[x] == 0) continue;
                    if (number[i] > number[x])
                        inversionCount++;

                }
            }
            return inversionCount;
        }

    }
}
