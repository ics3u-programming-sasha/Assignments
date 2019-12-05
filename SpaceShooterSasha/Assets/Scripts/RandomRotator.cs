using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {
    private Rigidbody rb;
    public float tumble;

    // Use this for initialization
    void Start()
    {
        //setting rb to the rigidbody
        rb = GetComponent<Rigidbody>();

        //randomly turning the astroid
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
