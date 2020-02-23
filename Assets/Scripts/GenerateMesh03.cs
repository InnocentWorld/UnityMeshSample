using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMesh03 : MonoBehaviour
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


        vertices.Add(new Vector3(0.0f, 1.0f, 0.0f));
        for (int i = 0; i < 5; i++)
        {
            vertices.Add(new Vector3(Mathf.Cos(72.0f * i * Mathf.Deg2Rad), 1.0f, Mathf.Sin(72.0f * i * Mathf.Deg2Rad)));
        }
        
        vertices.Add(new Vector3(0.0f, -1.0f, 0.0f));
        for (int i = 0; i < 5; i++)
        {
            vertices.Add(new Vector3(Mathf.Cos(72.0f * i * Mathf.Deg2Rad), - 1.0f, Mathf.Sin(72.0f * i * Mathf.Deg2Rad)));
        }

        for (int i = 0; i < 6; i++)
        {
            vertices.Add(new Vector3(Mathf.Cos(72.0f * i * Mathf.Deg2Rad), 1.0f, Mathf.Sin(72.0f * i * Mathf.Deg2Rad)));
        }
        for (int i = 0; i < 6; i++)
        {
            vertices.Add(new Vector3(Mathf.Cos(72.0f * i * Mathf.Deg2Rad), -1.0f, Mathf.Sin(72.0f * i * Mathf.Deg2Rad)));
        }


        for (int i = 0; i < 4; i++)
        {
            triangles.Add(0);
            triangles.Add(2 + i);
            triangles.Add(1 + i);
        }
        triangles.Add(0);
        triangles.Add(1);
        triangles.Add(5);
        
        for (int i = 0; i < 4; i++)
        {
            triangles.Add(6);
            triangles.Add(7 + i);
            triangles.Add(8 + i);
        }
        triangles.Add(6);
        triangles.Add(11);
        triangles.Add(7);
        
        
        for (int i = 0; i < 5; i++)
        {
            triangles.Add(12 + i);
            triangles.Add(13 + i);
            triangles.Add(18 + i);

            triangles.Add(13 + i);
            triangles.Add(19 + i);
            triangles.Add(18 + i);
        }
        
        uv.Add(new Vector2(0.5f, 0.5f));
        for (int i = 0; i < 5; i++)
        {
            uv.Add(new Vector2(0.5f + 0.5f * Mathf.Cos(72.0f * i * Mathf.Deg2Rad), 0.5f + 0.5f * Mathf.Sin(72.0f * i * Mathf.Deg2Rad)));
        }

        uv.Add(new Vector2(0.5f, 0.5f));
        for (int i = 0; i < 5; i++)
        {
            uv.Add(new Vector2(0.5f + 0.5f * Mathf.Cos(-72.0f * i * Mathf.Deg2Rad), 0.5f + 0.5f * Mathf.Sin(-72.0f * i * Mathf.Deg2Rad)));
        }

        for (int i = 0; i < 6; i++)
        {
            uv.Add(new Vector2(0.0f + i / 5.0f, 1.0f));
        }
        for (int i = 0; i < 6; i++)
        {
            uv.Add(new Vector2(0.0f + i / 5.0f, 0.0f));
        }

        
        SampleMesh.vertices = vertices.ToArray();
        SampleMesh.triangles = triangles.ToArray();
        SampleMesh.uv = uv.ToArray();

        SampleMesh.RecalculateNormals();
        SampleMesh.RecalculateBounds();

        SampleMeshFilter.sharedMesh = SampleMesh;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
