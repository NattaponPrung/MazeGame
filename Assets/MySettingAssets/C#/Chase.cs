using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Chase : MonoBehaviour {

	GameObject player;
	NavMeshAgent agent;
	//public float dist;
	//public float moveSpeed;
	//public float howClose;

	[SerializeField] float AttackRange = 1f;
	Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag ("Player");	//.transform
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		//dist = Vector3.Distance(player.position,transform.position);
        //if (dist <= howClose)
        //{
		//	transform.LookAt(player);
		//	GetComponent<Rigidbody>().AddForce(transform.forward = moveSpeed);
        //}

		agent.destination = player.transform.position;

		if (Vector3.Distance(transform.position, player.transform.position) < AttackRange)
			anim.SetTrigger("Attack");
	}
	void Attack ()
    {
		anim.SetTrigger("Attack");
		agent.enabled = false;
	}
}
