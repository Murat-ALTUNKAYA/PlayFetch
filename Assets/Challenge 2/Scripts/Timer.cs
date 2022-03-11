using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text time, healt, status, information;
    float timeCounter = 0.0f;
    public int healtCounter = 3;
    public static bool gameContinue = true;
    public GameObject button;

    void Start()
    {
        information.text = "Köpeklerle topu yakalamak için 'space' basabilirsin.";
    }

    void Update()
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
        healtCounter = healtCounter - 1;
        healt.text = healtCounter + "";
        if (healtCounter == 0)
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
