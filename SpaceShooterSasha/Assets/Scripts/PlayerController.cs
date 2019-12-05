using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    //declaring variables
    public float xMin, xMax, zMin, zMax;

}
public class PlayerController : MonoBehaviour {

    //variables
    private Rigidbody rb;
    public float speed;
    public float tilt;
    public Boundary boundray;
    public GameObject shot;
    public float shotRate;
    private float nextShot;
    public Transform shotSpawn;
    private AudioSource audioPlayer;

    void Start()
    {
        //setting rb to the rigidbody
        rb = GetComponent<Rigidbody>();
        //setting audioPlayer to the audio source
        audioPlayer = GetComponent<AudioSource>();
    }
    void FixedUpdate()
    {
        //getting input from the player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
   
        //vector3
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        
        //rigid body
        rb.velocity = movement * speed;

        rb.position = new Vector3
            (
                Mathf.Clamp(rb.position.x, boundray.xMin, boundray.xMax),
                0,
                Mathf.Clamp(rb.position.z, boundray.zMin, boundray.zMax)
            );

        //adding tilt
        rb.rotation = Quaternion.Euler(0, 0, rb.velocity.x * tilt);

    }
    void Update()
    {
        //seeing if the user can fire a shot
        if (Input.GetButton("Fire1") && Time.time > nextShot)
        {
            //setting the next time they can fire
            nextShot = Time.time + shotRate;

            //generating the shot 
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

            //playing the shot sound
            audioPlayer.Play();
        }
    }
}

