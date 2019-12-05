using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    private AudioSource audio;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();

        //repeat call the function
        InvokeRepeating("Fire", delay, fireRate);
	}

    void Fire()
    {
        //gernerating shot
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        audio.Play();

    }
}
