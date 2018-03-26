using UnityEngine;
//using Windows.Storage;

public class CreatingObject : MonoBehaviour
{

    public Vector3[] newVertices;
    public Vector2[] newUV;
    public int[] newTriangles;
    public Mesh mesh;

    // Use this for initialization
    void Start()
    {
        // OBJLoader.LoadOBJFile(ApplicationData.Current.LocalFolder.Path + @"\obj.obj");
        OBJLoader.LoadOBJFile("Assets/obj.obj");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
