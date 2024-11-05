using UnityEngine;

public class Exercicio10 : MonoBehaviour
{

    [SerializeField] bool moedas;
    [SerializeField] bool pocoes;
    [SerializeField] bool powerUp;
    [SerializeField] int moedasBolso = 10;
    [SerializeField] int vidaPlayer = 20;
    [SerializeField] int efeitos = 1;
    void Start()
    {
        switch (efeitos)
        {
            case 1:
                if (moedas == true)
                {
                    print("Moeda coletada");
                    moedasBolso++;
                }
            break;

            case 2:
                if (pocoes == true)
                {
                    print("Poção coletada");
                }
            break;

            case 3:
                if (powerUp == true)
                {
                    print("Power-Up coletado");
                    vidaPlayer = vidaPlayer + 10;
                }
            break;

            default:
                break;
        }
    }

    
    void Update()
    {
        
    }
}
