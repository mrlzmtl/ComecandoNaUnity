using UnityEngine;

public class Exercicio07 : MonoBehaviour
{
    
    [SerializeField] int numeroFaces = 10;
    
    void Start()
    {
        int resultado = Random.Range(1, numeroFaces);
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
