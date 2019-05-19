using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public int number;
    public Text Lifescore;
    // Start is called before the first frame update
    void Start()
    {
        number=PlayerPrefs.GetInt("LifeScore");
        Lifescore.text = "此次分数：" + number;
    }

    // Update is called once per frame
    public void OnClick()
    {
        SceneManager.LoadScene(1);
    }
}
