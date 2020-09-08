using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibujadorPuntos : Dibujador
{
    //ATRIBUTOS
    [Range(1,10)]
    int longitud = 10;
    
    [SerializeField, HideInInspector]
    Figura[] figura;
    MeshFilter[] meshFilter;

    
    protected override void Start()
    {
        Inicializar();
        CrearPuntos();
    }

    protected override void Inicializar()
    {
        base.Inicializar();
        meshFilter = new MeshFilter [myConfig.elementos];
        figura = new Figura[myConfig.elementos];
    }

    void CrearPuntos()
    {
        for(int i = 0; i < myConfig.elementos; ++i)
        {
            meshFilter[i] = new MeshFilter();
            
            GameObject meshObj = new GameObject("punto " + i.ToString());
            meshObj.transform.parent = transform;
            meshObj.AddComponent<MeshRenderer>().sharedMaterial = new Material(Shader.Find("Standard"));
            meshObj.GetComponent<MeshRenderer>().material.SetColor("_Color",Random.ColorHSV());
            
            meshFilter[i] = meshObj.AddComponent<MeshFilter>();
            meshFilter[i].sharedMesh = new Mesh();
            
            Vector3 centro = GenerarCentroAleatorio();//new Vector3(centro.x * i * 5, centro.y, centro.z);
            figura[i] = new Esfera(meshFilter[i].sharedMesh, centro, longitud);
            figura[i].CreateMesh();

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
        Vector3 resultado = new Vector3( Random.Range(myConfig.minValue.x + longitud, myConfig.maxValue.x - longitud), 
                                         Random.Range(myConfig.minValue.y + longitud, myConfig.maxValue.y - longitud), 
                                         Random.Range(myConfig.minValue.z + longitud, myConfig.maxValue.z - longitud));
        return resultado;
    }
}
