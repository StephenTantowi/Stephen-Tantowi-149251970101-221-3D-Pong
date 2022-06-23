using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int scoreP1;
    private int scoreP2;
    private int scoreP3;
    private int scoreP4;

    public Text txtP1;
    public Text txtP2;
    public Text txtP3;
    public Text txtP4;

    private int initScore = 15;

    // Start is called before the first frame update
    void Start()
    {
        scoreP1 = initScore;
        txtP1.text = scoreP1.ToString();
        scoreP2 = initScore;
        txtP2.text = scoreP2.ToString();
        scoreP3 = initScore;
        txtP3.text = scoreP3.ToString();
        scoreP4 = initScore;
        txtP4.text = scoreP4.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MinScoreP1(int point)
    {
        scoreP1 -= point;
        txtP1.text = scoreP1.ToString();
        if (scoreP1 <= 0)
        {
            
        }

    }
    public void MinScoreP2(int point)
    {
        Debug.Log("dsas");
        scoreP2 -= point;
        txtP2.text = scoreP2.ToString();
        if (scoreP2 <= 0)
        {

        }

    }
    public void MinScoreP3(int point)
    {
        scoreP3 -= point;
        txtP3.text = scoreP3.ToString();
        if (scoreP3 <= 0)
        {

        }

    }
    public void MinScoreP4(int point)
    {
        scoreP4 -= point;
        txtP4.text = scoreP4.ToString();
        if (scoreP4 <= 0)
        {

        }
    }
}
