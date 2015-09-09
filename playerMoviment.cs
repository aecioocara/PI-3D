using UnityEngine;
using System.Collections;

public class playerMoviment : MonoBehaviour 
{
	public float speed = 5F;
	public float jumpSpeed = 6.0F;
	public float molaSpeed = 6.0F;

	private Rigidbody rb;
	public float turnSmoothing = 15f;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		Vector3 Movement = new Vector3 (h, 0.0F, v);
		Movement = Movement * speed * Time.deltaTime;
		rb.MovePosition (transform.position + Movement);
		if (h != 0.0 || v != 0.0) 
		{
			Rotation(h,v);
		}


	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0)) 
		{
			Jump();
		}
	}

	void Rotation(float horizontal, float vertical)
	{
		Vector3 targetDirection = new Vector3(horizontal, 0f, vertical);
		Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
		Quaternion newRotation = Quaternion.Lerp(GetComponent<Rigidbody>().rotation, targetRotation, turnSmoothing * Time.deltaTime);
		rb.MoveRotation(newRotation);
	}

	void Jump()
	{
		rb.AddForce (Vector3.up * jumpSpeed);
	}

	void Mola()
	{
		rb.AddForce (Vector3.up * molaSpeed);
	}

	void OnCollisionEnter(Collision colisor)
	{
		if (colisor.gameObject.tag == "Mola") 
		{
			Mola();
		}
	}
}
