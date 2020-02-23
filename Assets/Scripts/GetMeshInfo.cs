using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMeshInfo : MonoBehaviour
{
    Mesh CubeMesh;
    // Start is called before the first frame update
    void Start()
    {
        CubeMesh = GetComponent<MeshFilter>().mesh;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("uv : " + CubeMesh.uv[0]);
        //Debug.Log("uv2 : " + CubeMesh.uv2[0]);
    }
}
