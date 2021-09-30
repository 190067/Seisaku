using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject score_Object = null;
    public static int Point = 0;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        Text score_text = score_Object.GetComponent<Text>();
        Point = Point + 1;
        score_text.text = "SCORE:" + Point;
    }
}
