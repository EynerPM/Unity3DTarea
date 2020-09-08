using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaFace {

    Mesh mesh;
    int resolution;
    Vector3 localUp;
    Vector3 axisA;
    Vector3 axisB;
    Vector3[] vertices;
    int[] triangles;


    public EsferaFace(Mesh mesh, int resolution)
    {
        this.mesh = mesh;
        this.resolution = resolution;

        vertices = new Vector3[resolution * resolution * 6];
        triangles = new int[(resolution - 1) * (resolution - 1) * 6 * 6];

    }

    public void ConstructMesh()
    {
        Vector3[] directions = { Vector3.up, Vector3.down, Vector3.left, Vector3.right, Vector3.forward, Vector3.back };


        int index_direction = 0;
        foreach(Vector3 direction in directions)
        {
            this.localUp = direction;
            
            axisA = new Vector3(localUp.y, localUp.z, localUp.x);
            axisB = Vector3.Cross(localUp, axisA);

            ConstructFace(index_direction);
            ++index_direction;
        }

        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }

    public void ConstructFace(int indexDirection)
    {
        int triIndex = (resolution - 1) * (resolution - 1) * 6 * indexDirection;

        for (int y = 0; y < resolution; y++)
        {
            for (int x = 0; x < resolution; x++)
            {
                int i = x + y * resolution + (resolution * resolution * indexDirection);
                Vector2 percent = new Vector2(x, y) / (resolution - 1) ;
                Vector3 pointOnUnitCube = localUp + (percent.x - .5f) * 2 * axisA + (percent.y - .5f) * 2 * axisB;
                Vector3 pointOnUnitSphere = pointOnUnitCube.normalized;
                Vector3 centro = new Vector3(3,3,3);
                vertices[i] = pointOnUnitSphere *2 + centro;

                if (x != resolution - 1 && y != resolution - 1)
                {
                    triangles[triIndex] = i;
                    triangles[triIndex + 1] = i + resolution + 1;
                    triangles[triIndex + 2] = i + resolution;

                    triangles[triIndex + 3] = i;
                    triangles[triIndex + 4] = i + 1;
                    triangles[triIndex + 5] = i + resolution + 1;
                    triIndex += 6;
                }
            }
        }
    }
}