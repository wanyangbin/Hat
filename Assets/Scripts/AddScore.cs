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
        
        if (coll.name.StartsWith ("Apple"))
        {
            Score++;
            ScoreNumber.text=Score.ToString();
            AudioSource.PlayClipAtPoint(Add, transform.position);
         
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
}
