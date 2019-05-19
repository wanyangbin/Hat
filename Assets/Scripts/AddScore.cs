using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AddScore : MonoBehaviour
{
    public int Score;
    public Text ScoreNumber;
    public int Lift;
    public Text LiftNumber;
    public GameObject Three;
    public GameObject Two;

    public AudioClip Add;

    public AudioClip Boom;

    

    void OnTriggerEnter2D(Collider2D coll)
    {


        //通过便签来进行判断加分，水果分数一样，超过20加2分，超过40加3分
        /*if (coll.tag.CompareTo("Apple") == 0)
        {
            Score++;
            if (Score > 20&&Score<40)
            {
                Score= Score+1;
            }
            if (Score > 40)
            {
                Score = Score + 2;
            }
            ScoreNumber.text=Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);

        }*/

        if (coll.name.StartsWith("Apple"))
        {
            Score++;
            ScoreNumber.text = Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);
        }

        if (coll.name.StartsWith("Grape"))
        {
            Score++;
            ScoreNumber.text = Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);
        }

        if (coll.name.StartsWith("Lemon"))
        {
            Score = Score + 2;
            ScoreNumber.text = Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);
        }
        if (coll.name.StartsWith("Mango"))
        {
            Score = Score + 2;
            ScoreNumber.text = Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);
        }
        if (coll.name.StartsWith("Orange"))
        {
            Score = Score + 3;
            ScoreNumber.text = Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);
        }
        if (coll.name.StartsWith("Pear"))
        {
            Score = Score + 3;
            ScoreNumber.text = Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);
        }
        if (coll.name.StartsWith("Pineapple"))
        {
            Score = Score+4;
            ScoreNumber.text = Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);
        }
        if (coll.name.StartsWith("Strawberry"))
        {
            Score = Score + 5;
            ScoreNumber.text = Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
            PlayerPrefs.SetInt("LifeScore", Score);
        }

        if (coll.name.StartsWith("bomb"))
        {

            Lift--;
            LiftNumber.text = Lift.ToString();
            AudioSource.PlayClipAtPoint(Boom, transform.position);
            if (Lift == 2|| Lift==1 )
            {
                Three.SetActive(false);
            }
            if (Lift == 1)
            {
                Two.SetActive(false);
            }
            if (Lift == 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    //60S倒计时

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
            PlayerPrefs.SetInt("LifeScore", Score);
            SceneManager.LoadScene(0);
        }

    }
    void GameOver()
    {
        t.GetComponent<Text>().text = "Gameover";
    }
}
