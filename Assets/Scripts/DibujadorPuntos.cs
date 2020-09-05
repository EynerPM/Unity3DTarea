using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibujadorPuntos : MonoBehaviour
{
    //ATRIBUTOS
    [Range(1,10)]
    int longitud = 10;
    public Configuracion myConfig;
    
    [SerializeField, HideInInspector]
    Figura[] figura;
    MeshFilter[] meshFilter;

    
    void Start()
    {
        //myConfig = new Configuracion();
        Screen.SetResolution(myConfig.screenWidth, myConfig.screenHeight, true);
        

        meshFilter = new MeshFilter [myConfig.elementos];
        figura = new Figura[myConfig.elementos];
        //centro = new Vector3(1,0,0);

        for(int i = 0; i < myConfig.elementos; ++i)
        {
            meshFilter[i] = new MeshFilter();
            
            GameObject meshObj = new GameObject("punto " + i.ToString());
            meshObj.transform.parent = transform;
            meshObj.AddComponent<MeshRenderer>().sharedMaterial = new Material(Shader.Find("Standard"));
            
            meshFilter[i] = meshObj.AddComponent<MeshFilter>();
            meshFilter[i].sharedMesh = new Mesh();
            
            Vector3 centro = GenerarCentroAleatorio();//new Vector3(centro.x * i * 5, centro.y, centro.z);
            figura[i] = new Cubo(meshFilter[i].sharedMesh, centro, longitud);
            figura[i].CreateMesh();

        }
    }

    Vector3 GenerarCentroAleatorio()
    {
        Vector3 resultado = new Vector3( Random.Range(myConfig.minValue.x + longitud, myConfig.maxValue.x - longitud), 
                                         Random.Range(myConfig.minValue.y + longitud, myConfig.maxValue.y - longitud), 
                                         Random.Range(myConfig.minValue.z + longitud, myConfig.maxValue.z - longitud));
        return resultado;
    }
}
