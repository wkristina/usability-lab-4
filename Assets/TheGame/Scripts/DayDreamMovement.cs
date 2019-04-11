using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


// Quelle: https://codingchronicles.com/unity-vr-development/day-62-of-100-days-of-vr-implementing-movement-in-google-daydream


public class DayDreamMovement : MonoBehaviour
{
    private float _speedSlowDown;
    private Camera camera;

    void Start()
    {
        _speedSlowDown = 0.1f;
        camera = Camera.main;
    }

    void Update()
    {
      camera.transform.position += new Vector3(0, 1, 0);
        if (GvrControllerInput.IsTouching)
        {
            Debug.Log("Touchpad touched");
            Vector3 touchPos = GvrControllerInput.TouchPos;
            Vector3 movementVector = new Vector3(touchPos.x - 0.5f, 2, touchPos.y - 0.5f); //adjust for center to be at 0.5, 0.5
 //           Vector3 playerPos = movementVector;
 //           camera.transform.position = playerPos;
            transform.Translate(movementVector.x * _speedSlowDown, 0, -movementVector.z * _speedSlowDown); // negative to adjust for the vector speed
        }
    }


}