using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboTest : FiguraTest
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }


    protected override void MeshData(){
        vertices = new Vector3[]
        {
            new Vector3(-1,-1,-1),
            new Vector3(-1, 1,-1),
            new Vector3( 1, 1,-1),
            new Vector3( 1,-1,-1),
            new Vector3(-1,-1, 1),
            new Vector3(-1, 1, 1),
            new Vector3( 1, 1, 1),
            new Vector3( 1,-1, 1)
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

    new void CreateMesh(){
        base.CreateMesh();
    }
}
