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
        else if (playerGuerreiro == false && playerMago == true)
        {
            print("Mago Escolhido");
        }
        else
        {
            print("Escolha uma das classes");
        }
    }

    
    void Update()
    {
        
    }
}
