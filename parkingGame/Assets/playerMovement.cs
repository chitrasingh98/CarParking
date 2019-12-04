using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
	float accelerationPower = 5f;
	[SerializeField]
	float steeringPower = 5f;
	float steeringAmount, speed, direction;

    public Rigidbody2D rb;
  //  Vector2 movement;
    // Update is called once per frame
    // void Update()
    // {
    //     movement.x = Input.GetAxisRaw("Horizontal");
    //     movement.y = Input.GetAxisRaw("Vertical");
    // }
    void FixedUpdate(){
        steeringAmount = - Input.GetAxis ("Horizontal");
		speed = Input.GetAxis ("Vertical") * accelerationPower;
		direction = Mathf.Sign(Vector2.Dot (rb.velocity, rb.GetRelativeVector(Vector2.up)));
		rb.rotation += steeringAmount * steeringPower * rb.velocity.magnitude * direction;

		rb.AddRelativeForce (Vector2.up * speed);

		rb.AddRelativeForce ( - Vector2.right * rb.velocity.magnitude * steeringAmount / 2);
    }
}
