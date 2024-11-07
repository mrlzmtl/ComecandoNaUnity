using UnityEngine;

public class Exercicio08 : MonoBehaviour
{

    /*[SerializeField] int hora = 20;
    [SerializeField] int segundos = 1;
    [SerializeField] int dias = 1;*/

    [SerializeField] int dias;
    [SerializeField] float segundos;
    [SerializeField] int horas;

    void Start()
    {
        
    }

    
    void Update()
    {
        //minha tentativa
        /*segundos += 1;
        if (segundos == 100) 
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
        }*/

        //versão tadeu
        segundos += Time.deltaTime;

        if (segundos >= 10f)
        {
            horas++;
            segundos = 0;
            if (horas == 24)
            {
                dias++;
                horas = 0;
                print(dias);
            }
        }
    }
}
