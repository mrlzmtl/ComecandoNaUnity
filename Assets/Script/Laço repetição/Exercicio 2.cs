using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    [SerializeField] int ataque = 0;
    void Start()
    {
        while (ataque <= 5)
        {
            int combo = Random.Range(1, 20);
            print(combo * 2);
            ataque++;
        }
    }

    
    void Update()
    {
        
    }
}
