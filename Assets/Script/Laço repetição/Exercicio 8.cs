using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    string programa;
    [SerializeField]string nome = "Amalia";
    void Start()
    {
        for (int i = nome.Length; i > 0; i--)
        {
            programa += nome[i - 1];
        }
        print(programa);
    }

    
    void Update()
    {
        
    }
}
