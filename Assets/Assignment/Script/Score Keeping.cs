using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeping : MonoBehaviour
{

    public static int score = 0;
    public TextMeshProUGUI scoreKeep;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        AddScore();
    }

    public  void AddScore()
    {
       scoreKeep.text = "Score: " + score;

    }
}
