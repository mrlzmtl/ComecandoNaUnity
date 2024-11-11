using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    [SerializeField] int ataque = 0;
    void Start()
    {
        while (ataque <= 7)
        {
            int combo = Random.Range(1, 20);
            print(combo + 10);
            ataque++;
        }
    }

    
    void Update()
    {
        
    }
}
