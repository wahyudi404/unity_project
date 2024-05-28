using UnityEngine;
using System.Collections;

public class DestroySelf : MonoBehaviour {
    void Update () {
        if (transform.position.y < -5f) {
            Debug.Log("Destroying object: " + gameObject.name);
            Destroy (gameObject);
        }
    }
}