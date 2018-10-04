using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSouls : MonoBehaviour {

    private PlayerController pc;

	// Use this for initialization
	void Start () {
        pc = gameObject.GetComponentInParent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp") && collision.gameObject.activeSelf == true)
        {
            if(pc.luzFarol.intensity > 0)
            {
                GameController.instance.SoulsCounter = GameController.instance.SoulsCounter + 1;
                collision.gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp") && collision.gameObject.activeSelf == true)
        {
            if (pc.luzFarol.intensity > 0)
            {
                GameController.instance.SoulsCounter = GameController.instance.SoulsCounter + 1;
                collision.gameObject.SetActive(false);
            }
        }
    }

}
