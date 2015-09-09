using UnityEngine;
using System.Collections;

public class EnemyIA : MonoBehaviour {

	public Transform[] patrolWayPoint;
	public Transform playerDead;

	private NavMeshAgent nav;
	public int wayPointIndex;

	// Use this for initialization
	void Awake () {
		nav = GetComponent<NavMeshAgent> ();
	}

	void Start (){
		//transform.position = patrolWayPoint [0].position;
		wayPointIndex = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, patrolWayPoint[wayPointIndex].position) < 0.5f) {
			wayPointIndex++;
		}
		if (wayPointIndex >= patrolWayPoint.Length) {
			wayPointIndex = 0;
		}
		nav.destination = patrolWayPoint [wayPointIndex].position;
	}

	void Patrulha(){
		nav.destination = patrolWayPoint [wayPointIndex].position;
	}

	void deadPlayer()
	{
		playerDead.gameObject.SetActive (false);
	}

	void OnCollisionEnter(Collision colisor)
	{
		if (colisor.gameObject.tag == "Player") 
		{
			deadPlayer();
		}
	}
}
