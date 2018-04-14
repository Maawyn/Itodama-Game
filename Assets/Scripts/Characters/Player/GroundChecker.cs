using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {

    PlayerController pc;

	// Use this for initialization
	void Start () {
        pc = gameObject.GetComponentInParent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter Trigger");
        pc.grounded = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       // Debug.Log("stay Trigger");
       //pc.grounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit Trigger");
        pc.grounded = false;
    }
}
