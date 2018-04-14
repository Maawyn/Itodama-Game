using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController instance = null;

    private int soulsCounter = 0;
    //private Canvas canvas;
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }


    // Use this for initialization
    void Start () {
        //canvas = GameObject.FindGameObjectWithTag("HUB").GetComponent<Canvas>();
        //counter = GameObject.Find("Counter").GetComponent<Text>();
    }

    public int SoulsCounter { get; set; }
}
