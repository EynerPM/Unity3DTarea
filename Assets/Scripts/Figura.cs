using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figura
{
    //ATRIBUTOS
    protected Mesh mesh;

    protected Vector3[] vertices;
    protected int[] triangulos;
    protected Vector3[] normales; // falta
    protected Color[] color;      // falta

    protected Vector3 centro;
    protected int longitud;

    //METODOS
    public Figura(Mesh _mesh, Vector3 _centro, int _longitud)
    {
        this.mesh = _mesh;
        this.centro = _centro;
        this.longitud = _longitud;
        MeshData(); 
    }

    protected virtual void MeshData()
    {
        // Llenamos la data
    }

    public void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangulos;
        mesh.RecalculateNormals();
    }
}
