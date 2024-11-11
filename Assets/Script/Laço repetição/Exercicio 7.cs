using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Exercicio7 : MonoBehaviour
{
    public List<int> numeros = new List<int> { 11, 82, 70, 14, 36, 95 };
    void Start()
    {
        int maiorNumero = numeros[0];

        foreach (int num in numeros)
        {
            if (num > maiorNumero)
            {
                maiorNumero = num;
            }
        }

        print(maiorNumero);
    }

    
    void Update()
    {
        
    }
}
