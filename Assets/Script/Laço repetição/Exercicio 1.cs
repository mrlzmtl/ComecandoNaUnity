using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    [SerializeField] int y = 5;
    void Start()
    {
        while (y > 0)
        {
            print(y);
            y--;
        }

        if (y == 0)
        {
            print("In�cio da partida!");
        }
    }


    void Update()
    {
        
    }
}
