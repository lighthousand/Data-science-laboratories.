using Academy.HoloToolkit.Unity;
using UnityEngine;

/// <summary>
/// GestureAction performs custom actions based on
/// which gesture is being performed.
/// </summary>
public class GestureAction : MonoBehaviour
{
    [Tooltip("Rotation max speed controls amount of rotation.")]
    public float RotationSensitivity = 1.0f;

    private Vector3 manipulationPreviousPosition;

    //private float scaleFactor;
    //private float scaleFcator1;
    private Vector3 lastPosition;
    private Vector3 scaleDirection;

    private void Start()
    {
        lastPosition = GazeManager.Instance.Position;
    }

    void Update()
    {
        PerformScale();
        lastPosition = GazeManager.Instance.Position;
    }

    private void PerformScale()
    {
        if (GestureManager.Instance.IsNavigating)
        {
            /* TODO: DEVELOPER CODING EXERCISE 2.c */

            // 2.c: Calculate scaleFactor based on GestureManager's NavigationPosition.X and multiply by RotationSensitivity.
            // This will help control the amount of rotation.


            scaleDirection = GazeManager.Instance.Position - lastPosition;

            Debug.Log(scaleDirection);

            //scaleFactor1 = GestureManager.Instance.NavigationPosition.y * RotationSensitivity;
            // 2.c: transform.Rotate along the Y axis using scaleFactor.
            //transform.Rotate(new Vector3(-1* scaleFactor1, -1 * scaleFactor, 0));
            //System.Diagnostics.Debug.WriteLine("X:"+GestureManager.Instance.NavigationPosition.x+" y:"+ GestureManager.Instance.NavigationPosition.y + "z:" + GestureManager.Instance.NavigationPosition.z + "\n");


            if (scaleDirection.x >= 0)
                if (GazeManager.Instance.Position.x > BoxScript2.Instance.centerObject.transform.position.x)
                {
                    this.transform.parent.transform.parent.transform.localScale *= 1.01F;
                    Debug.Log("marire");
                }
                else
                {
                    this.transform.parent.transform.parent.transform.localScale /= 1.01F;
                    Debug.Log("micsosare");
                }
            else
                 if (GazeManager.Instance.Position.x < BoxScript2.Instance.centerObject.transform.position.x)
                {
                    this.transform.parent.transform.parent.transform.localScale *= 1.01F;
                    Debug.Log("marire");
                }
                else
                {
                    this.transform.parent.transform.parent.transform.localScale /= 1.01F;
                    Debug.Log("micsosare");
                }



            //if (scaleFactor > 0)
            //{
            //    this.transform.parent.transform.parent.transform.localScale *= 1.01F;
            //}
            //else
            //    if (scaleFactor < 0)
            //        this.transform.parent.transform.parent.transform.localScale /= 1.01F;
        }
    }

    void PerformManipulationStart(Vector3 position)
    {
        manipulationPreviousPosition = position;
    }

    void PerformManipulationUpdate(Vector3 position)
    {
        if (GestureManager.Instance.IsManipulating)
        {
            /* TODO: DEVELOPER CODING EXERCISE 4.a */

            Vector3 moveVector = Vector3.zero;

            // 4.a: Calculate the moveVector as position - manipulationPreviousPosition.

            // 4.a: Update the manipulationPreviousPosition with the current position.

            // 4.a: Increment this transform's position by the moveVector.
        }
    }
}