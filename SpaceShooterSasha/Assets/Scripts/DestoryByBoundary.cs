using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        //get ride of other game objects
        Destroy(other.gameObject);
    }
}
