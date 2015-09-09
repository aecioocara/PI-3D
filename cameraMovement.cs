using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour 
{

	public Transform player;
	public float speed = 6.0f;
	public GameObject target = null;
	public float turnSpeed = 15.0f;
	public Rigidbody rbCamera;
	public int teste = 0;
	public float xyzDamp = 2.0f;
	private float heightX = 8.0f;
	private float heightY = 4.0f;
	private float heightZ = 4.0f;
	public int  setCamera = 1;



	// Use this for initialization
	void Start () 
	{
		teste = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		//float h = Input.GetAxis("Horizontal");
		//float v = Input.GetAxis("Vertical");
		float cH = Input.GetAxis("rightAnalogicH");
		float cV = Input.GetAxis ("rightAnalogicV");




		if (teste == 1) {

			Vector3 Movement = new Vector3 (cH, 0.0F, cV);
			//Movement = Movement * speed * Time.deltaTime;
			rbCamera.MovePosition (transform.position * Time.deltaTime + Movement);
		}
		


		transform.LookAt (target.transform);

		if (teste == 0) 
		{
			float currentHeightX = transform.position.x;
			float currentHeightY = transform.position.y;
			float currentHeightZ = transform.position.z;

			float wantedHeightX = player.transform.position.x + heightX;
			float wantedHeightY = player.transform.position.y + heightY;
			float wantedHeightZ = player.transform.position.z - heightZ;



			float currentHeightXDamp = Mathf.Lerp(currentHeightX,wantedHeightX,xyzDamp*Time.deltaTime);
			float currentHeightYDamp = Mathf.Lerp(currentHeightY,wantedHeightY,xyzDamp*Time.deltaTime);
			float currentHeightZDamp = Mathf.Lerp(currentHeightZ,wantedHeightZ,xyzDamp*Time.deltaTime);

			transform.position = new Vector3(currentHeightXDamp,currentHeightYDamp,currentHeightZDamp);


		}

	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Joystick1Button6) && setCamera == 1)
		{
			heightX = 4.0f;
			setCamera = 0;
		}
		else if(Input.GetKeyDown(KeyCode.JoystickButton6) && setCamera == 0)
		{
			heightX = 8.0f;
			setCamera = 1;
		}
	}


}
