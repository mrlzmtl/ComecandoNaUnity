using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    [SerializeField] string nome = "Amalia";
    [SerializeField] int consoantes = 0;
    void Start()
    {
        string vogais = "aeiouAEIOU";

        foreach (char letra in nome)
        {
            if (char.IsLetter(letra) && !vogais.Contains(letra))
            {
                consoantes++;
            }
        }

        print("Consoantes: " + consoantes);
    }

    
    void Update()
    {
        
    }
}
