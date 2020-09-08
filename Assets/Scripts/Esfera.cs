using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : Figura
{
    //ATRIBUTOS EXTRA
    int resolution = 10;
    Vector3 localUp;
    Vector3 axisA;
    Vector3 axisB;


    //METODOS
    public Esfera(Mesh _mesh, Vector3 _centro, int _longitud) : base(_mesh, _centro, _longitud)
    {
        //
    }

    protected override void MeshData()
    {
        vertices = new Vector3[resolution * resolution * 6];
        triangulos = new int[(resolution - 1) * (resolution - 1) * 6 * 6];


        Vector3[] directions = { Vector3.up, Vector3.down, Vector3.left, Vector3.right, Vector3.forward, Vector3.back };


        int indexOfFace = 0;
        foreach(Vector3 direction in directions)
        {
            this.localUp = direction;
            
            axisA = new Vector3(localUp.y, localUp.z, localUp.x);
            axisB = Vector3.Cross(localUp, axisA);

            ConstructFace(indexOfFace);
            ++indexOfFace;
        }
    }

    void ConstructFace(int indexOfFace)
    {
        int triIndex = (resolution - 1) * (resolution - 1) * 6 * indexOfFace;

        for (int y = 0; y < resolution; y++)
        {
            for (int x = 0; x < resolution; x++)
            {
                int i = x + y * resolution + (resolution * resolution * indexOfFace);
                Vector2 percent = new Vector2(x, y) / (resolution - 1) ;
                Vector3 pointOnUnitCube = localUp + (percent.x - .5f) * 2 * axisA + (percent.y - .5f) * 2 * axisB;
                Vector3 pointOnUnitSphere = pointOnUnitCube.normalized;
                vertices[i] = pointOnUnitSphere * longitud + centro;

                if (x != resolution - 1 && y != resolution - 1)
                {
                    triangulos[triIndex] = i;
                    triangulos[triIndex + 1] = i + resolution + 1;
                    triangulos[triIndex + 2] = i + resolution;

                    triangulos[triIndex + 3] = i;
                    triangulos[triIndex + 4] = i + 1;
                    triangulos[triIndex + 5] = i + resolution + 1;
                    triIndex += 6;
                }
            }
        }
    }

    new public void CreateMesh()
    {
        base.CreateMesh();
    }

}
