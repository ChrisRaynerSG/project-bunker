using UnityEngine;
using UnityEngine.Rendering;

public static class MeshUtilities
{
    public static void CreateFaceUp(MeshData meshData, Vector3 origin)
    {
        Vector3[] vertices = new Vector3[4];

        vertices[0] = new Vector3(origin.x - .5f, origin.y + .5f, origin.z - .5f);
        vertices[1] = new Vector3(origin.x + .5f, origin.y + .5f, origin.z - .5f);
        vertices[2] = new Vector3(origin.x + .5f, origin.y + .5f, origin.z + .5f);
        vertices[3] = new Vector3(origin.x - .5f, origin.y + .5f, origin.z + .5f);

        meshData.vertices.AddRange(vertices);

        int[] triangles = new int[6];
        triangles[0] = meshData.vertices.Count - 4;
        triangles[1] = meshData.vertices.Count - 3;
        triangles[2] = meshData.vertices.Count - 2;

        triangles[3] = meshData.vertices.Count - 4;
        triangles[4] = meshData.vertices.Count - 2;
        triangles[5] = meshData.vertices.Count - 1;

        meshData.triangles.AddRange(triangles);
    }
}