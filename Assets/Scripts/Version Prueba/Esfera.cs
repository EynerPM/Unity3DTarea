using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    [Range(2,256)]
    public int resolution = 10;

    [SerializeField, HideInInspector]
    MeshFilter[] meshFilters;
    EsferaFace[] esferaFaces;
     
	private void OnValidate()
	{
        Initialize();
        GenerateMesh();
	}

	void Initialize()
    {
        if (meshFilters == null || meshFilters.Length == 0)
        {
            meshFilters = new MeshFilter[6];
        }
        esferaFaces = new EsferaFace[6];

        Vector3[] directions = { Vector3.up, Vector3.down, Vector3.left, Vector3.right, Vector3.forward, Vector3.back };

        for (int i = 0; i < 6; i++)
        {
            if (meshFilters[i] == null)
            {
                GameObject meshObj = new GameObject("mesh");
                meshObj.transform.parent = transform;

                meshObj.AddComponent<MeshRenderer>().sharedMaterial = new Material(Shader.Find("Standard"));
                meshFilters[i] = meshObj.AddComponent<MeshFilter>();
                meshFilters[i].sharedMesh = new Mesh();
            }

            esferaFaces[i] = new EsferaFace(meshFilters[i].sharedMesh, resolution, directions[i]);
        }
    }

    void GenerateMesh()
    {
        foreach (EsferaFace face in esferaFaces)
        {
            face.ConstructMesh();
        }
    }
}



/*[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof (MeshRenderer))]
public class Esfera : MonoBehaviour
{
    MeshFilter[] meshFilters;

    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //base.Update();
    }
}*/

