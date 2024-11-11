using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    int num;
    void Start()
    {
        for (int num = 0; num <= 10000; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                print("Fizz Buzz");
            }
            else if (num % 3 == 0)
            {
                print("Fizz");
            }
            else if (num % 5 == 0)
            {
                print("Buzz");
            }
            else
            {
                print(num);
            }
        }
    }

    
    void Update()
    {
        
    }
}
