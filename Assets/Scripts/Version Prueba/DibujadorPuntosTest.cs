using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibujadorPuntosTest : MonoBehaviour
{
    Vector3 centro;
    public int longitud = 1;

    [SerializeField, HideInInspector]
    CuboPrueba cubo;
    MeshFilter meshFilter;
    

    void OnValidate()
    {
        Initialize();
    }

    // Start is called before the first frame update
    void Initialize()
    {
        meshFilter = new MeshFilter();

        GameObject meshObj = new GameObject("mesh");//, typeof(MeshFilter), typeof(MeshRenderer));
        meshObj.transform.parent = transform;
        meshObj.AddComponent<MeshRenderer>().sharedMaterial = new Material(Shader.Find("Standard"));

        //Mesh mesh =  new Mesh();

        //meshObj.GetComponent<MeshFilter>().mesh = mesh;

        meshFilter = meshObj.AddComponent<MeshFilter>();
        meshFilter.sharedMesh = new Mesh();

        centro = new Vector3(0,0,0);

        cubo = new CuboPrueba(meshFilter.sharedMesh, centro, longitud);
        cubo.CreateMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
