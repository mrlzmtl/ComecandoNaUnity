using UnityEngine;

public class Exercicio05 : MonoBehaviour
{

    [SerializeField] int pontosPlayer = 0;
    void Start()
    {
        if (pontosPlayer >= 50)
        {
            print("Miss�o bem-sucedida");
        }
        else
        {
            print("Miss�o incompleta");
        }
    }

    
    void Update()
    {
        
    }
}
