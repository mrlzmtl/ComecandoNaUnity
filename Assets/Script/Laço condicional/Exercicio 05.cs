using UnityEngine;

public class Exercicio05 : MonoBehaviour
{

    [SerializeField] int pontosPlayer = 0;
    void Start()
    {
        if (pontosPlayer >= 50)
        {
            print("Missão bem-sucedida");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    
    void Update()
    {
        
    }
}
