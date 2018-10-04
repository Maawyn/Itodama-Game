using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HubController : MonoBehaviour {

    public Text counter;

    // Update is called once per frame
    void Update()
    {
        RefreshHUB();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameController.instance.isPause = !GameController.instance.isPause;
        }
        if (GameController.instance.SoulsCounter == 3)
        {
            GameController.instance.isWinning = true;
            //GameController.instance.musicInGame.Stop();
        }

        if (GameController.instance.isGameover)
        {
            GameController.instance.gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                GameController.instance.isGameover = false;
                SceneManager.LoadScene("MainScreen", LoadSceneMode.Single);
            }
        }

        if (GameController.instance.isWinning)
        {
            Time.timeScale = 0;
            GameController.instance.winning.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                GameController.instance.isWinning = false;
                SceneManager.LoadScene("MainScreen", LoadSceneMode.Single);
            }
        }

        if (GameController.instance.isPause)
        {
            GameController.instance.pauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        } else
        {
            deactivePauseMenu();
        }
    }

    void RefreshHUB()
    {
        counter.text = GameController.instance.SoulsCounter.ToString();
    }

    public void deactivePauseMenu()
    {
        GameController.instance.isPause = false;
        GameController.instance.pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
