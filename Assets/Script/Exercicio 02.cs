using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    [SerializeField] bool powerUP;
    void Start()
    {
        if (powerUP == true)
        {
            print("Power-up Coletado");
        }
        else
        {
            print("Nenhum power-up encontrado");
        }
    }

    
    void Update()
    {
        
    }
}
