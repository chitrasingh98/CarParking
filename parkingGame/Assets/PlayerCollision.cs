using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	public playerMovement movement;		// A reference to our PlayerMovement script

	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter2D (Collision2D collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{  Debug.Log("collision detected");
              Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
		//movement.enabled = false;	// Disable the players movement.
		}
	}

}
