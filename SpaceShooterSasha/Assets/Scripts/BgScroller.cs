using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroller : MonoBehaviour {
    //variables
    public float scrollSpeed;
    public float tileLenghtZ;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        float newPostion = Mathf.Repeat(Time.time * scrollSpeed, tileLenghtZ);

        transform.position = startPosition + Vector3.forward * newPostion;

    }
}
