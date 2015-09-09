using UnityEngine;
using System.Collections;

public class teste : MonoBehaviour {

	private float speedFollow = 60.0f;
	public GameObject teste2;
	public Rigidbody gb;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector3 testeMov = new Vector3 (teste2.transform.position.x, teste2.transform.position.y, teste2.transform.position.z);
		gb.MovePosition (transform.position * Time.deltaTime + testeMov);
		//transform.position = new Vector3 (teste2.transform.position.x, teste2.transform.position.y, teste2.transform.position.z);
	
	}
}
