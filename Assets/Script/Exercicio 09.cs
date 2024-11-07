using UnityEngine;

public class Exercicio09 : MonoBehaviour
{

    [SerializeField] int timeA = 0;
    [SerializeField] int timeB = 0;
    
    void Start()
    {
        if (timeA > timeB)
        {
            print("Vitória do time A");
        }
        else if (timeA < timeB)
        {
            print("Vitória do time B");
        }
        else if (timeA >= 3 && timeB >= 3)
        {
            print("Empate emocionante");
        }
        else if (timeA == timeB)
        {
            print("Empate");
        }
    }

    
    void Update()
    {
        
    }
}
