using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMesh : MonoBehaviour
{

    //Material SampleMaterial;
    Mesh SampleMesh;
    MeshFilter SampleMeshFilter;
    //MeshRenderer SampleMeshRenderer;

    List<Vector3> vertices;
    List<int> triangles;
    List<Vector2> uv;

    // Start is called before the first frame update
    void Start()
    {
        SampleMesh = new Mesh();

        SampleMeshFilter = GetComponent<MeshFilter>();
        //SampleMeshRenderer = GetComponent<MeshRenderer>();

        vertices = new List<Vector3>();
        triangles = new List<int>();
        uv = new List<Vector2>();

        vertices.Add(new Vector3(-1.0f, 0.0f, -1.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, 1.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, 1.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, -1.0f));

        triangles.AddRange(new List<int>() { 0, 1, 2, 0, 2, 3});

        uv.Add(new Vector2(0.0f, 0.0f));
        uv.Add(new Vector2(0.0f, 1.0f));
        uv.Add(new Vector2(1.0f, 1.0f));
        uv.Add(new Vector2(1.0f, 0.0f));

        SampleMesh.vertices = vertices.ToArray();
        SampleMesh.triangles = triangles.ToArray();
        SampleMesh.uv = uv.ToArray();

        SampleMesh.RecalculateBounds();
        SampleMesh.RecalculateNormals();

        SampleMeshFilter.sharedMesh = SampleMesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
