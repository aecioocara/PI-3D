using UnityEngine;
using System.Collections;

public class chocolateLento : MonoBehaviour 
{
	public Transform player;
	private float speedLow;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider colisor)
	{
		if (colisor.gameObject.tag == "Player") 
		{

			player.GetComponent<playerMoviment> ().speed = 2.0f;
			player.GetComponent<playerMoviment> ().jumpSpeed = 150.0f;

		}




	}

	void OnTriggerExit(Collider colisor)
	{
		if (colisor.gameObject.tag == "Player") 
		{
			
			player.GetComponent<playerMoviment> ().speed = 5.0f;
			player.GetComponent<playerMoviment> ().jumpSpeed = 300.0f;
			
		}
	}
}
