using UnityEngine;

public class Exercicio11 : MonoBehaviour
{

    [SerializeField] string estadoPlayer;
    void Start()
    {
        switch (estadoPlayer)
        {
            case "Normal":
                print("Olá!");
            break;

            case "Machucado":
                print("Eita, apanhou foi?");
            break;

            case "Morrendo":
                print("MEU DEUS!!");
            break;

            default:
                print("*Silêncio*");
                break;
        }
    }

    
    void Update()
    {
        
    }
}
