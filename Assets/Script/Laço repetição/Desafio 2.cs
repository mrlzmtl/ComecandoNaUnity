using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    [SerializeField] int diaAniver;
    [SerializeField] int mesAniver;
    [SerializeField] int anoAniver;
    void Start()
    {
        int diaAtual = System.DateTime.Now.Day;
        int mesAtual = System.DateTime.Now.Month;
        int anoAtual = System.DateTime.Now.Year;

        int dia = diaAtual - diaAniver;

        int mes = mesAtual - mesAniver;

        int ano = anoAtual - anoAniver;

        print("Idade: " + ano + "anos, " + mes + " meses, " + dia + " dias.");
    }

    
    void Update()
    {
        foreach (var item in transform)
        {
            
        }

    }
}
