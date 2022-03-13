using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text time, healt, status, information;
    float timeCounter = 0.0f;
    public int HealtCounter = 3;
    public static bool gameContinue = true;
    public GameObject button;

    void Start()
    {
        information.text = "Köpeklerle topu yakalamak için 'space' tuþuna basabilirsin.";
    }

    void Update()
    {
        TimeControl();
    }
    private void TimeControl()
    {
        if (gameContinue)
        {
            timeCounter += Time.deltaTime;
            time.text = (int)timeCounter + "";
            button.SetActive(false);
        }
        else
        {
            status.text = "Süre : " + (int)timeCounter + "sn.";
            button.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        HealtCounter = HealtCounter - 1;
        healt.text = HealtCounter + "";
        if (HealtCounter == 0)
        {
            gameContinue = false;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        gameContinue = true;
    }
}
