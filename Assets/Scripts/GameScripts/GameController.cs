using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Canvas pauseMenu;
    public Canvas gameOver;
    public Canvas winning;

    public AudioSource musicInGame;
    public AudioSource musicCredits;

    public bool isPause = false;
    public bool isGameover = false;
    public bool isWinning = false;

    public bool stoppedGame;

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
        //DontDestroyOnLoad(gameObject);
    }


    // Use this for initialization
    void Start () {
        //canvas = GameObject.FindGameObjectWithTag("HUB").GetComponent<Canvas>();
        //counter = GameObject.Find("Counter").GetComponent<Text>();
        //pauseMenu = GameObject.Find("pauseMenu").GetComponent<Canvas>();
        //gameOver = GameObject.Find("CanvasGameOver").GetComponent<Canvas>();
        //winning = GameObject.Find("CanvasWinning").GetComponent<Canvas>();
        pauseMenu.gameObject.SetActive(false);
        musicCredits.Stop();
        musicInGame.Play();
    }

    public bool IsStopped()
    {
        if (isGameover){
            musicInGame.Stop();
            return true;
        } else if (isWinning)
        {
            musicCredits.Play();
            return true;
        }
        return false;
    }

    public int SoulsCounter { get; set; }
}
