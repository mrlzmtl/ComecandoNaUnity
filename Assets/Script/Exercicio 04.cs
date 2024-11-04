using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool inventarioPocao;
    void Start()
    {
        if (inventarioPocao == true)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }
    }

    
    void Update()
    {
        
    }
}
