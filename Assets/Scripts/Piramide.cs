using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piramide : Figura
{
    //METODOS
    public Piramide(Mesh _mesh, Vector3 _centro, int _longitud) : base(_mesh, _centro, _longitud)
    {
        //
    }

    protected override void MeshData()
    {
        vertices = new Vector3[]
        {
            new Vector3(centro.x - 1, centro.y - 1, centro.z - 1),
            new Vector3(centro.x - 1, centro.y - 1, centro.z + 1),
            new Vector3(centro.x + 1, centro.y - 1, centro.z + 1),
            new Vector3(centro.x + 1, centro.y - 1, centro.z - 1),
            new Vector3(centro.x    , centro.y + 1, centro.z    )
        };

        triangulos = new int[]
        {
            4, 3, 0,//front
            4, 0, 1,//left
            4, 2, 3,//right
            4, 1, 2,//back
            0, 2, 1,//bottom
            0, 3, 2
        };
    }

    new public void CreateMesh()
    {
        base.CreateMesh();
    }

}
