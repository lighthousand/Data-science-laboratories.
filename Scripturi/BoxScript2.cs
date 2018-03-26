using Academy.HoloToolkit.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxScript2 : Singleton<BoxScript2>
{
    public GameObject centerObject;

    public Color color = Color.green;

    private Vector3 v3FrontTopLeft;
    private Vector3 v3FrontTopRight;
    private Vector3 v3FrontBottomLeft;
    private Vector3 v3FrontBottomRight;
    private Vector3 v3BackTopLeft;
    private Vector3 v3BackTopRight;
    private Vector3 v3BackBottomLeft;
    private Vector3 v3BackBottomRight;

    private GameObject cube1;
    private GameObject cube2;
    private GameObject cube3;
    private GameObject cube4;
    private GameObject cube5;
    private GameObject cube6;
    private GameObject cube7;
    private GameObject cube8;

    public Material mat;

    void Start()
    {
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // GameObject gameObject = new GameObject();
        // Canvas canvas = gameObject.AddComponent<Canvas>();
        // canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        // canvas.pixelPerfect = true;

        // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //// cube.AddComponent<Rigidbody>();
        // cube.transform.position = v3FrontBottomRight;
        // cube.transform.localScale += new Vector3(1.5F, 1.5F, 1.5F);
        // var boxCollider2 = cube.AddComponent<BoxCollider>();
        CalcPositons();

        centerObject = new GameObject();
        centerObject.transform.position = transform.position;
        centerObject.transform.parent = transform;

        cube1.transform.localScale = transform.localScale * 0.1f;
        cube2.transform.localScale = transform.localScale * 0.1f;
        cube3.transform.localScale = transform.localScale * 0.1f;
        cube4.transform.localScale = transform.localScale * 0.1f;
        cube5.transform.localScale = transform.localScale * 0.1f;
        cube6.transform.localScale = transform.localScale * 0.1f;
        cube7.transform.localScale = transform.localScale * 0.1f;
        cube8.transform.localScale = transform.localScale * 0.1f;

        cube1.transform.SetParent(centerObject.transform);
        cube2.transform.SetParent(centerObject.transform);
        cube3.transform.SetParent(centerObject.transform);
        cube4.transform.SetParent(centerObject.transform);
        cube5.transform.SetParent(centerObject.transform);
        cube6.transform.SetParent(centerObject.transform);
        cube7.transform.SetParent(centerObject.transform);
        cube8.transform.SetParent(centerObject.transform);

        cube1.AddComponent<GestureAction>();
        cube1.AddComponent<GestureManager>();
        cube1.AddComponent<InteractibleManager>();

        cube2.AddComponent<GestureAction>();
        cube2.AddComponent<GestureManager>();
        cube2.AddComponent<InteractibleManager>();

        cube3.AddComponent<GestureAction>();
        cube3.AddComponent<GestureManager>();
        cube3.AddComponent<InteractibleManager>();

        cube4.AddComponent<GestureAction>();
        cube4.AddComponent<GestureManager>();
        cube4.AddComponent<InteractibleManager>();

        cube5.AddComponent<GestureAction>();
        cube5.AddComponent<GestureManager>();
        cube5.AddComponent<InteractibleManager>();

        cube6.AddComponent<GestureAction>();
        cube6.AddComponent<GestureManager>();
        cube6.AddComponent<InteractibleManager>();

        cube7.AddComponent<GestureAction>();
        cube7.AddComponent<GestureManager>();
        cube7.AddComponent<InteractibleManager>();

        cube8.AddComponent<GestureAction>();
        cube8.AddComponent<GestureManager>();
        cube8.AddComponent<InteractibleManager>();


        //if (Physics.Raycast(GazeManager.Instance.Position, this.transform.position))
        //DrawBox();
    }

    void Update()
    {
        CalcPositons();
        //if (GazeManager.Instance.Hit)
        //if (Physics.Raycast(GazeManager.Instance.Position, this.transform.position))
        DrawBox();
    }

    void CalcPositons()
    {
        Bounds bounds = GetComponent<MeshFilter>().mesh.bounds;

        Vector3 v3Center = bounds.center;
        Vector3 v3Extents = bounds.extents;

        v3FrontTopLeft = new Vector3(v3Center.x - v3Extents.x, v3Center.y + v3Extents.y, v3Center.z - v3Extents.z);  // Front top left corner
        v3FrontTopRight = new Vector3(v3Center.x + v3Extents.x, v3Center.y + v3Extents.y, v3Center.z - v3Extents.z);  // Front top right corner
        v3FrontBottomLeft = new Vector3(v3Center.x - v3Extents.x, v3Center.y - v3Extents.y, v3Center.z - v3Extents.z);  // Front bottom left corner
        v3FrontBottomRight = new Vector3(v3Center.x + v3Extents.x, v3Center.y - v3Extents.y, v3Center.z - v3Extents.z);  // Front bottom right corner
        v3BackTopLeft = new Vector3(v3Center.x - v3Extents.x, v3Center.y + v3Extents.y, v3Center.z + v3Extents.z);  // Back top left corner
        v3BackTopRight = new Vector3(v3Center.x + v3Extents.x, v3Center.y + v3Extents.y, v3Center.z + v3Extents.z);  // Back top right corner
        v3BackBottomLeft = new Vector3(v3Center.x - v3Extents.x, v3Center.y - v3Extents.y, v3Center.z + v3Extents.z);  // Back bottom left corner
        v3BackBottomRight = new Vector3(v3Center.x + v3Extents.x, v3Center.y - v3Extents.y, v3Center.z + v3Extents.z);  // Back bottom right corner

        v3FrontTopLeft = transform.TransformPoint(v3FrontTopLeft);
        v3FrontTopRight = transform.TransformPoint(v3FrontTopRight);
        v3FrontBottomLeft = transform.TransformPoint(v3FrontBottomLeft);
        v3FrontBottomRight = transform.TransformPoint(v3FrontBottomRight);
        v3BackTopLeft = transform.TransformPoint(v3BackTopLeft);
        v3BackTopRight = transform.TransformPoint(v3BackTopRight);
        v3BackBottomLeft = transform.TransformPoint(v3BackBottomLeft);
        v3BackBottomRight = transform.TransformPoint(v3BackBottomRight);

    }

    void DrawBox()
    {
        cube1.transform.position = v3FrontTopLeft;
        cube2.transform.position = v3FrontTopRight;
        cube3.transform.position = v3FrontBottomLeft;
        cube4.transform.position = v3FrontBottomRight;
        cube5.transform.position = v3BackTopLeft;
        cube6.transform.position = v3BackTopRight;
        cube7.transform.position = v3BackBottomLeft;
        cube8.transform.position = v3BackBottomRight;
    }

    void OnRenderObject()
    {
        mat.SetPass(0);

        GL.Begin(GL.LINES);

        GL.Vertex(v3FrontTopLeft);
        GL.Vertex(v3FrontTopRight);

        GL.Vertex(v3FrontTopRight);
        GL.Vertex(v3FrontBottomRight);

        GL.Vertex(v3FrontBottomRight);
        GL.Vertex(v3FrontBottomLeft);

        GL.Vertex(v3FrontBottomLeft);
        GL.Vertex(v3FrontTopLeft);

        //
        GL.Vertex(v3BackTopLeft);
        GL.Vertex(v3BackTopRight);

        GL.Vertex(v3BackTopRight);
        GL.Vertex(v3BackBottomRight);

        GL.Vertex(v3BackBottomRight);
        GL.Vertex(v3BackBottomLeft);

        GL.Vertex(v3BackBottomLeft);
        GL.Vertex(v3BackTopLeft);

        //
        GL.Vertex(v3FrontTopLeft);
        GL.Vertex(v3BackTopLeft);

        GL.Vertex(v3FrontTopRight);
        GL.Vertex(v3BackTopRight);

        GL.Vertex(v3FrontBottomRight);
        GL.Vertex(v3BackBottomRight);

        GL.Vertex(v3FrontBottomLeft);
        GL.Vertex(v3BackBottomLeft);


        GL.End();
    }
}
