using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S_Result : MonoBehaviour
{
    public GameObject score_Object = null;
    int S = ScoreManager.Point;

    void Start()
    {

    }

    void Update()
    {
        Text score_text = score_Object.GetComponent<Text>();
        score_text.text = "SCORE:" + S + "!";

        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
