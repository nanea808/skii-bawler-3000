using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    private Camera cam;

    private bool pressingMouse = false;

    private void Start() {
        cam = Camera.main;
    }

    // private void OnMouseDown() {
    //     pressingMouse = true;
    // }

    // private void OnMouseUp() {
    //     pressingMouse = false;
    // }

    private void Update() {
        if (Input.GetMouseButtonDown(0))
            pressingMouse = true;
        if (Input.GetMouseButtonUp(0))
            pressingMouse = false;
        
        if(pressingMouse) {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 0;
            mousePosition.y = 0;
            Debug.Log(mousePosition);

            transform.LookAt(mousePosition);
        }
    }
}
    
