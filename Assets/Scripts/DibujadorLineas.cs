using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibujadorLineas : Dibujador
{
    //ATRIBUTOS
    [Range(1,8)]
    int grosor = 8;
    [Range(30,50)]
    int distancia;   


    protected override void Start()
    {
        Inicializar();
        CrearLineas();
    }

    protected override void Inicializar()
    {
        base.Inicializar();
        distancia = Random.Range(30,50);
    }

    void CrearLineas()
    {   
        for(int i = 0; i < myConfig.elementos; ++i)
        {
            
            GameObject meshCilindro = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            meshCilindro.transform.parent = transform;
            meshCilindro.name = "linea " + i.ToString();

            // Genera la malla Cilindro
            Vector3 centro = GenerarCentroAleatorio();
            Vector3 rotacion = GenerarRotacionAleatorio();
            Vector3 escalamiento = GenerarEscalamiento();

            meshCilindro.transform.position = centro;
            meshCilindro.transform.Rotate(rotacion.x, rotacion.y, rotacion.z);
            meshCilindro.transform.localScale += escalamiento;

        }
    }

    new public void Mostrar()
    {
        base.Mostrar();
    }

    new public void Ocultar()
    {
        base.Ocultar();
    }

    protected override Vector3 GenerarCentroAleatorio()
    {
        Vector3 resultado = new Vector3( Random.Range(myConfig.minValue.x + (distancia/2), myConfig.maxValue.x - (distancia/2)), 
                                         Random.Range(myConfig.minValue.y + (distancia/2), myConfig.maxValue.y - (distancia/2)), 
                                         Random.Range(myConfig.minValue.z + (distancia/2), myConfig.maxValue.z - (distancia/2)));
        return resultado;
    }

    Vector3 GenerarRotacionAleatorio()
    {
        Vector3 resultado = new Vector3( Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        return resultado;
    }

    Vector3 GenerarEscalamiento()
    {
        Vector3 resultado = new Vector3( grosor - 1, distancia/2 , grosor -1);
        return resultado;
    }

}
