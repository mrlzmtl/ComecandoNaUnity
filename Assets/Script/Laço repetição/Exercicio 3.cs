using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    [SerializeField] int fase = 1;
    [SerializeField] int moedas = 10;
    void Start()
    {
        while (fase <= 10)
        {
            moedas = moedas + 3;
            print("Fase " + fase + "- Moedas coletadas: " + moedas);
            fase++;
        }
    }

    
    void Update()
    {
        
    }
}
