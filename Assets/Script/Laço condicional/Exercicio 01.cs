using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    [SerializeField] int vidaJogador = 20;
    [SerializeField] int dano = 25;
    void Start()
    {
        int vida = vidaJogador - dano;

        if (vida <= 0)
        {
            print("Game Over");
        }
        else
        {
            print("Personagem Vivo");
        }
    }

    
    void Update()
    {
        
    }
}
