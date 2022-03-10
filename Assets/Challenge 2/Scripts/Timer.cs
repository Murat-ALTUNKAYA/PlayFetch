using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text time, healt;
    float timeCounter = 0.0f;
    public int healtCounter = 3;

    void Start()
    {

    }

    void Update()
    {
        timeCounter += Time.deltaTime;
        time.text = (int)timeCounter + "";
    }
    
    private void OnTriggerEnter(Collider other)
    {
        healtCounter = healtCounter - 1;
        healt.text = healtCounter + "";
    }
}
