﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : Figura
{
    //METODOS
    public Cubo(Mesh _mesh, Vector3 _centro, int _longitud) : base(_mesh, _centro, _longitud)
    {
        //
    }

    protected override void MeshData()
    {
        vertices = new Vector3[]
        {
            new Vector3(centro.x - longitud, centro.y - longitud, centro.z - longitud),
            new Vector3(centro.x - longitud, centro.y + longitud, centro.z - longitud),
            new Vector3(centro.x + longitud, centro.y + longitud, centro.z - longitud),
            new Vector3(centro.x + longitud, centro.y - longitud, centro.z - longitud),
            new Vector3(centro.x - longitud, centro.y - longitud, centro.z + longitud),
            new Vector3(centro.x - longitud, centro.y + longitud, centro.z + longitud),
            new Vector3(centro.x + longitud, centro.y + longitud, centro.z + longitud),
            new Vector3(centro.x + longitud, centro.y - longitud, centro.z + longitud)
        };

        triangulos = new int[]
        {
            0, 1, 2,//front
            0, 2, 3,
            0, 4, 5,//left
            0, 5, 1,
            6, 5, 4,//back
            6, 4, 7,
            3, 2, 6,//right
            3, 6, 7,
            2, 1, 5,//top
            2, 5, 6,
            0, 7, 4,//bottom
            0, 3, 7
        };
    }

    new public void CreateMesh()
    {
        base.CreateMesh();
    }

}