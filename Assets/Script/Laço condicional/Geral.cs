using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{
    //[SerializeField] int vidaHeroi = 100;
    //[SerializeField] int vidaVilao = 300;
    //string resultado;

    [SerializeField] int estadoVilao = 1;

    void Start()
    {
        //print(vidaVilao == vidaHeroi);
        //print(vidaHeroi <= vidaVilao);
        //print(vidaVilao != vidaHeroi);

        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior";

        //print(resultado);

        //if (vidaHeroi < vidaVilao)
        //{
        //    resultado = "Vida Heroi Menor";
        //    print(resultado);
        //}
        //else if (vidaHeroi == vidaVilao)
        //{
        //    resultado = "Vida Heroi igual a Vida Vilao";
        //    print(resultado);
        //}
        //else 
        //{
        //    resultado = "Vida Heroi Maior";
        //    print(resultado);
        //}

        switch(estadoVilao)
        {
            case 1:
                print("Vil�o atacando");
                break;

            case 2:
                print("Vil�o defende");
                break;

            case 3:
                print("Vil�o tomando um dano");
                break;

            default:
                print("Valor n�o identificado");
                break;
        }
    }

    void Update()
    {

    }
}