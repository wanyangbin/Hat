using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public GameObject bomb;
    private float maxWidth;
    public float time;
    private GameObject newball;
    private GameObject newbomb;
    
    void Start()
    {
        Vector3 screenPos = new Vector3(Screen.width, 0, 0);
        Vector3 moveWidth = Camera.main.ScreenToWorldPoint(screenPos);
        float ballWidth = ball.GetComponent<Renderer>().bounds.extents.x;
        maxWidth = moveWidth.x - ballWidth;
        float bombWidth = bomb.GetComponent<Renderer>().bounds.extents.x;
        maxWidth = moveWidth.x - bombWidth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = Random.Range(1.0f, 1.5f);
            float posX = Random.Range(-maxWidth, maxWidth);
            Vector3 spawnPosition = new Vector3(posX, 5, 0);
            newball = (GameObject)Instantiate(ball, spawnPosition, Quaternion.identity);
            Destroy(newball, 10);
        }
    }
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = Random.Range(1.0f, 1.5f);
            float bombX = Random.Range(-maxWidth, maxWidth);
            Vector3 bombPosition = new Vector3(bombX, 5, 0);
            newbomb = (GameObject)Instantiate(bomb, bombPosition, Quaternion.identity);
            Destroy(newbomb, 10);
        }
    }
}
