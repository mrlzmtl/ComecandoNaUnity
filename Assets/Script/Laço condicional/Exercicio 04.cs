using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool inventarioPocao;
    void Start()
    {
        if (inventarioPocao == true)
        {
            print("Usando Po��o de Vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }
    }

    
    void Update()
    {
        
    }
}
