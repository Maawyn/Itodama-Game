using UnityEngine;
using UnityEngine.UI;

public class HubController : MonoBehaviour {

    public Text counter;

    // Update is called once per frame
    void Update()
    {
        RefreshHUB();
    }

    void RefreshHUB()
    {
        counter.text = GameController.instance.SoulsCounter.ToString();
    }
}
