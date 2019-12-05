using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evasive : MonoBehaviour {
    //variables
    public Vector2 startWait;
    public Vector2 maneuverTime;
    public Vector2 maneuverWait;

    private float targetManeuver;
    private float currentSpeed;
    public float doge;
    public float smoothing;
    public float tilt;

    private Rigidbody rb;

    public Boundary boundary;


    void Start ()
    {
        //starting the coroutine
        StartCoroutine(Evade());

        //setting rb to the rigidbody
        rb = GetComponent<Rigidbody>();

        currentSpeed = rb.velocity.z;
    }

    IEnumerator Evade()
    {
        //waiting for time
        yield return new WaitForSeconds(Random.Range(startWait.x, startWait.y));

        while (true)
        {
            targetManeuver = Random.Range(1, doge) * -Mathf.Sign (transform.position.x);
            //waiting for it to move
            yield return new WaitForSeconds(Random.Range(maneuverTime.x, maneuverTime.y));
            targetManeuver = Random.Range(1, doge) * -Mathf.Sign(transform.position.x);
            //waiting for it to move
            yield return new WaitForSeconds (Random.Range(maneuverTime.x, maneuverTime.y));

        }
    }

	void FixedUpdate ()
    {
        float newManeuver = Mathf.MoveTowards(rb.velocity.x, targetManeuver, Time.deltaTime * smoothing);

        //setting the rigid body to a vetcor 3
        rb.velocity = new Vector3(newManeuver, 0.0f, currentSpeed);

        //clamp the enemy
        rb.position = new Vector3
            (
                Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
                0,
                Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
            );

        //adding tilt
        rb.rotation = Quaternion.Euler(0, 0, rb.velocity.x * -tilt);
    }
}
