using UnityEngine;
using System.Collections;

public class cameraAlternativa : MonoBehaviour 
{

	public Transform player;
	public float xyzDamp = 2.0f;
	private float heightX = 8.0f;
	private float heightY = 4.0f;
	private float heightZ = 4.0f;
	public GameObject target = null;
	


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float currentHeightX = transform.position.x;
		float currentHeightY = transform.position.y;
		float currentHeightZ = transform.position.z;
		
		//float wantedHeightX = player.transform.position.x + heightX;
		float wantedHeightY = player.transform.position.y + heightY;
		float wantedHeightZ = player.transform.position.z - heightZ;
		
		
		
		//float currentHeightXDamp = Mathf.Lerp(currentHeightX,wantedHeightX,xyzDamp*Time.deltaTime);
		float currentHeightYDamp = Mathf.Lerp(currentHeightY,wantedHeightY,xyzDamp*Time.deltaTime);
		//float currentHeightZDamp = Mathf.Lerp(currentHeightZ,wantedHeightZ,xyzDamp*Time.deltaTime);
		
		transform.position = new Vector3(player.transform.position.x,currentHeightYDamp, player.transform.position.z - 8f);



	}
}
