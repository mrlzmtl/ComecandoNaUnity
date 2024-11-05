using UnityEngine;

public class Exercicio08 : MonoBehaviour
{

    [SerializeField] int hora = 20;
    [SerializeField] int segundos = 1;
    [SerializeField] int dias = 1;
    void Start()
    {
        
    }

    
    void Update()
    {
        segundos += 1;
        if (segundos == 10) 
        {
            hora += 1;
            print("Horário: " + hora);
            segundos = 0;
        }

        if (hora == 24)
        {
            dias += 1;
            hora = 0;
            print("Dia " + dias);
            print("Horário: " + hora);
        }
    }
}
