using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace P3_Lab10_Kol2
{
    public static class RODO
    {
        public static string ExtRodo(this string nazwisko)
        {
            char[] arr=nazwisko.ToCharArray();
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                arr[i] = '*';
            }

            string nazwa = new string(arr);

            return nazwa;
        }
    }
}
