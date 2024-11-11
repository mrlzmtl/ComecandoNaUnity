using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    //int x = 0;
    //int y = 10;

    List<int> nums = new List<int>();
    void Start()
    {
        //for (int i = 0; i <= 10; i++)
        //{
        //    if (i == 5)
        //    {
        //        break;
        //    }

        //    if (i == 6)
        //    {
        //        continue;
        //    }

        //    print(i);
        //}

        //-------------------------------------------------------------

        //while (x<=10) 
        //{ 
        //    print(x);
        //    x++;
        //}

        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y <= 0);

        //-------------------------------------------------------------

        //int[] num = {10, 20, 30, 40, 50, 60, 70, 80};

        //print(num[3]);
        //num[0]++;

        //print(num[0]);

        //string[] nomes;

        //nomes = new string[5];

        //nomes[0] = "Tadola";

        //print(nomes[1]);

        //-------------------------------------------------------------

        //foreach (var item in num)
        //{
        //    print(item);
        //}

        nums.Add(1);
        nums.Add(2);    
        nums.Add(3);    
        nums.Add(4);
        nums.Add(4);
        nums.Add(5);
        nums.Add(6);
        nums.Add(7);
        nums.Add(8);
        nums.Add(9);

        //nums.Remove(4);

        //nums.Sort();

        //nums.Reverse();

        print(nums.IndexOf(1));
    }

    
    void Update()
    {
        
    }
}
