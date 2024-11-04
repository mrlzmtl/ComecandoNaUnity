using UnityEngine;

public class Exercicio08 : MonoBehaviour
{

    [SerializeField] int hora = 20;
    int segundos = 1;
    int dias = 1;
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
