using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "goal") {
            Debug.Log("ENTER");
            //TODO: make a destroy timer
            // Destroy(gameObject);
        }
    }

    // void OnTriggerStay(Collider other) {
    //     if(other.gameObject.tag == "goal") {
    //         Debug.Log("STAY");
    //     }
    // }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "goal") {
            Debug.Log("EXIT");
        }
    }
}
