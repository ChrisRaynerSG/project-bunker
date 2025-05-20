using UnityEngine;
public class WorldGenerator : MonoBehaviour
{
    MeshFilter filter;
    public int maxX = 16;
    public int maxZ = 16;

    void Start()
    {
        filter = GetComponent<MeshFilter>();
        MeshData meshData = GenerateWorld();

        
        LoadMeshData(meshData);
    }

    MeshData GenerateWorld()
    {
        MeshData meshData = new MeshData();
        for (int x = 0; x < maxX; x++)
        {
            for (int z = 0; z < maxZ; z++)
            {
                Vector3 targetPosition = Vector3.zero;
                targetPosition.x = x * 1;
                targetPosition.z = z * 1;
                MeshUtilities.CreateFaceUp(meshData, targetPosition);
                // MeshUtilities.CreateFaceDown(meshData, targetPosition); maybe later if we want to look up at cubes
                MeshUtilities.CreateFaceNorth(meshData, targetPosition);
                MeshUtilities.CreateFaceEast(meshData, targetPosition);
                MeshUtilities.CreateFaceSouth(meshData, targetPosition);
                MeshUtilities.CreateFaceWest(meshData, targetPosition);
            }
        }
        return meshData;
    }

    public void LoadMeshData(MeshData meshData)
    {
        Mesh mesh = new Mesh()
        {
            vertices = meshData.vertices.ToArray(),
            triangles = meshData.triangles.ToArray(),
            uv = meshData.uvs.ToArray()
        };
        filter.mesh = mesh;
    }

}