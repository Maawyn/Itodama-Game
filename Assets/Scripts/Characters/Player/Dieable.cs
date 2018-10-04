using UnityEngine;

public class Dieable : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Die"))
        {
            GameController.instance.isGameover = true;
        }
    }
}