using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinigamiAI : MonoBehaviour
{
    public float rotationSpeed;
    public float distance;

    // Use this for initialization
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up * -1, distance);
        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);

            if (hitInfo.collider.CompareTag("Player") && hitInfo.collider.gameObject.GetComponent<PlayerController>().IsTorchEnabled())
            {
                Destroy(hitInfo.collider.gameObject);
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
        }
    }
}