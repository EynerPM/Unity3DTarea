using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiramideTest : FiguraTest
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
            new Vector3(-1,-1, 1),
            new Vector3( 1,-1, 1),
            new Vector3( 1,-1,-1),
            new Vector3( 0, 1, 0)
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

    new void CreateMesh(){
        base.CreateMesh();
    }
}
