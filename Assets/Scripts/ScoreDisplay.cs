using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;
    Score scoreObj;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreObj = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreObj.GetScore().ToString();
    }
}
