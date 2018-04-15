using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainControllerScreen : MonoBehaviour {

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }

    public void Play()
    {
        SceneManager.LoadScene("Level-1", LoadSceneMode.Single);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
