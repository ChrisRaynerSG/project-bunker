using System.Collections.Generic;
using UnityEngine;

public class MeshData
{
    public List<Vector3> vertices = new List<Vector3>();
    public List<int> triangles = new List<int>();
    public List<Vector2> uvs = new List<Vector2>();

    public void AddVertices(List<Vector3> vertices)
    {
        this.vertices.AddRange(vertices);
    }
    public void AddTriangles(List<int> triangles)
    {
        this.triangles.AddRange(triangles);
    }

    public void AddUVs(List<Vector2> uvs)
    {
        this.uvs.AddRange(uvs);
    }
}