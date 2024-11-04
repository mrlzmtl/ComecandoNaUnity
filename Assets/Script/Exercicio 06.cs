using UnityEngine;

public class Exercicio06 : MonoBehaviour
{

    [SerializeField] bool playerGuerreiro;
    [SerializeField] bool playerMago;
    void Start()
    {
        if (playerGuerreiro == true && playerMago == false)
        {
            print("Guerreiro escolhido");
        }
        else
        {
            print("Mago Escolhido");
        }
    }

    
    void Update()
    {
        
    }
}
