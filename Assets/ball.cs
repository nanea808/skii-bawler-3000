using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    void onTriggerEnter(Collider other) {
        if (other.gameObject.tag == "enemy") {
            print("");
        }
    }

    void onTriggerStay(Collider other) {
        
    }

    void onTriggerExit(Collider other) {
        
    }
}
