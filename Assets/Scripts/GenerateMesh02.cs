using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GenerateMesh02 : MonoBehaviour
{

    Mesh SampleMesh;
    MeshFilter SampleMeshFilter;

    List<Vector3> vertices;
    List<int> triangles;
    List<Vector2> uv;

    // Start is called before the first frame update
    void Start()
    {
        SampleMesh = new Mesh();

        SampleMeshFilter = GetComponent<MeshFilter>();

        vertices = new List<Vector3>();
        triangles = new List<int>();
        uv = new List<Vector2>();

        vertices.Add(new Vector3(0.0f, Mathf.Sqrt(2.0f), 0.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, -1.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, 1.0f));

        vertices.Add(new Vector3(0.0f, Mathf.Sqrt(2.0f), 0.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, -1.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, -1.0f));

        vertices.Add(new Vector3(0.0f, Mathf.Sqrt(2.0f), 0.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, 1.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, -1.0f));

        vertices.Add(new Vector3(0.0f, Mathf.Sqrt(2.0f), 0.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, 1.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, 1.0f));



        vertices.Add(new Vector3(0.0f, -Mathf.Sqrt(2.0f), 0.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, 1.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, -1.0f));

        vertices.Add(new Vector3(0.0f, -Mathf.Sqrt(2.0f), 0.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, -1.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, -1.0f));

        vertices.Add(new Vector3(0.0f, -Mathf.Sqrt(2.0f), 0.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, -1.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, 1.0f));

        vertices.Add(new Vector3(0.0f, -Mathf.Sqrt(2.0f), 0.0f));
        vertices.Add(new Vector3(1.0f, 0.0f, 1.0f));
        vertices.Add(new Vector3(-1.0f, 0.0f, 1.0f));


        for(int i=0; i<24; i++)
        {
            triangles.Add(i);
        }
        //triangles.AddRange(new List<int>() { 0, 1, 4, 1, 2, 4, 2, 3, 4, 3, 0, 4, 1, 0, 5, 2, 1, 5, 3, 2, 5, 0, 3, 5});

       for(int i=0; i<8; i++)
        {
            uv.Add(new Vector2(0.5f, Mathf.Sqrt(3.0f) / 2.0f));
            uv.Add(new Vector2(0.0f, 0.0f));
            uv.Add(new Vector2(1.0f, 0.0f));
        }

        SampleMesh.vertices = vertices.ToArray();
        SampleMesh.triangles = triangles.ToArray();
        SampleMesh.uv = uv.ToArray();

        SampleMesh.RecalculateNormals();
        SampleMesh.RecalculateBounds();

        SampleMeshFilter.sharedMesh = SampleMesh;
        

        var path = string.Format("Assets/octahedron.asset");
        AssetDatabase.CreateAsset(SampleMesh, path);
        AssetDatabase.SaveAssets();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
