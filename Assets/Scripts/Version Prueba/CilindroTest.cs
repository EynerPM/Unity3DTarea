using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof (MeshRenderer))]
public class CilindroTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        //base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //base.Update();
    }
}
