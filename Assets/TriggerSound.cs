using UnityEngine;
using System.Collections;

public class TriggerSound : MonoBehaviour {
    public AudioSource hitSound;
    void Start() {
    hitSound = GetComponent<AudioSource> ();
    }
    void OnTriggerEnter(Collider other) {
        hitSound.Play ();
    }
}