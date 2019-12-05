using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    //getting the explosion refrence
    public GameObject explosion;
    public GameObject playerExplosion;

    public int scoreValue;
    private GameController gameController;
    
   void Start()
    {
        //making the harzards find the game controller
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        //checking to see if the tag is there
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        //check to make sure even after all it doesn't work
        if (gameControllerObject == null)
        {
            Debug.Log("Can not find Game Controller object");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //if it is trigger by the boundary don't call it
        if (other.CompareTag ("boundary") || other.CompareTag ("Enemy"))
        {
            return;
        }

        if (explosion != null)
        {
            //generating the explostion 
            Instantiate(explosion, transform.position, transform.rotation);
        }
  
        if (other.CompareTag ("Player"))
        {
            //generating the player explosion
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);

            //call the game over
            gameController.GameOver();

        }
        //destroying the shot and astroid
        Destroy(other.gameObject);
        Destroy(gameObject);

        //add to the score
        gameController.AddScore(scoreValue);
    }

}
