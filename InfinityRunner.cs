using UnityEngine;
using System.Collections;

public class InfinityRunner : MonoBehaviour {

	public GameObject groundTransform;
	public float damp = 2.0f;
	public Rigidbody rbPlayer;
	public float speed = 6.0f;
	public float jumpSpeed = 6.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Joystick1Button2)) 
		{
			if(groundTransform.transform.position.x >= 3)
			{

			}else
			{
				//float agoraX = groundTransform.transform.position.x;
				//float queroX = groundTransform.transform.position.x+3;
				//float depoisXDamp = Mathf.Lerp(agoraX,queroX,damp*Time.deltaTime);

				groundTransform.transform.position = new Vector3 (groundTransform.transform.position.x+3,
				                                                  groundTransform.transform.position.y,
				                                                  groundTransform.transform.position.z);
			}



		}

		if (Input.GetKeyDown (KeyCode.Joystick1Button1)) 
		{
			if(groundTransform.transform.position.x <= -3)
			{

			}else
			{
				groundTransform.transform.position = new Vector3 (groundTransform.transform.position.x-3,
				                                                  groundTransform.transform.position.y,
				                                                  groundTransform.transform.position.z);
			}
		}

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Joystick1Button0)) 
		{
			Jump();
		}

	}

	void FixedUpdate()
	{
		Vector3 movi = new Vector3 (0f, 0f, 1f);
		movi = movi * speed * Time.deltaTime;
		rbPlayer.MovePosition (transform.position + movi);

	}

	void Jump()
	{
		rbPlayer.AddForce (Vector3.up * jumpSpeed);
	}
}
