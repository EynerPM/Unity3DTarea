using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof (MeshRenderer))]
public class FiguraTest : MonoBehaviour
{
    // ATRIBUTOS
    protected Mesh mesh;

    protected Vector3[] vertices;
    protected int[] triangulos;
    protected Vector3[] normales;
    protected Color[] color;


    // METODOS

    // Start is called before the first frame update
    protected void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        
        MeshData();
        CreateMesh();
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }

    protected virtual void MeshData()
    {
        // Llenamos la data
    }

    protected void CreateMesh()
    {
        mesh.Clear();
        
        /*color = new Color[vertices.Length];
        for(int i = 0; i < vertices.Length; ++i)
        {
            color[i] = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }*/

        mesh.vertices = vertices;
        mesh.triangles = triangulos;
        //mesh.colors = color;
        mesh.RecalculateNormals();
    }
}

