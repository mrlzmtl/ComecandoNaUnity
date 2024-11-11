using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    [SerializeField] int fase = 1;
    [SerializeField] int dificuldade = 0;
    void Start()
    {
        while (fase <= 6)
        {
            dificuldade = dificuldade + 5;
            print("Fase " + fase + ": Dificuldade " + dificuldade);
            fase++;
        }
    }

    
    void Update()
    {
        
    }
}
