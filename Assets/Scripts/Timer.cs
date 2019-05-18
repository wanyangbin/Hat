using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float timer = 60;
    public GameObject t;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            t.GetComponent<Text>().text = timer.ToString("00");
        }
        else //GameOver();
        {
            SceneManager.LoadScene(0);
        }

    }
    void GameOver()
    {
        t.GetComponent<Text>().text = "Gameover";
    }
}