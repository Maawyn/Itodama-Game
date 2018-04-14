using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSouls : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp") && collision.gameObject.activeSelf == true)
        {
            GameController.instance.SoulsCounter = GameController.instance.SoulsCounter + 1;
            collision.gameObject.SetActive(false);
        }
    }

}
