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

    public GameObject panel;

    public GameObject paddle1;
    public GameObject paddle2;
    public GameObject paddle3;
    public GameObject paddle4;

    public GameObject goal1;
    public GameObject goal2;
    public GameObject goal3;
    public GameObject goal4;

    public GameObject wallp1;
    public GameObject wallp2;
    public GameObject wallp3;
    public GameObject wallp4;

    public bool p1D = false;
    public bool p2D = false;
    public bool p3D = false;
    public bool p4D = false;

    public Text winner;

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
        WinnerCheck();
    }

    public void MinScoreP1(int point)
    {
        scoreP1 -= point;
        txtP1.text = scoreP1.ToString();
        if (scoreP1 <= 0)
        {
            paddle1.SetActive(false);
            goal1.SetActive(false);
            wallp1.SetActive(true);
            p1D = true;
        }

    }
    public void MinScoreP2(int point)
    {
        scoreP2 -= point;
        txtP2.text = scoreP2.ToString();
        if (scoreP2 <= 0)
        {
            paddle2.SetActive(false);
            goal2.SetActive(false);
            wallp2.SetActive(true);
            p2D = true;
        }

    }
    public void MinScoreP3(int point)
    {
        scoreP3 -= point;
        txtP3.text = scoreP3.ToString();
        if (scoreP3 <= 0)
        {
            paddle3.SetActive(false);
            goal3.SetActive(false);
            wallp3.SetActive(true);
            p3D = true;
        }

    }
    public void MinScoreP4(int point)
    {
        scoreP4 -= point;
        txtP4.text = scoreP4.ToString();
        if (scoreP4 <= 0)
        {
            paddle4.SetActive(false);
            goal4.SetActive(false);
            wallp4.SetActive(true);
            p4D = true;
        }
    }

    private void WinnerCheck()
    {
        if(p1D == true && p2D == true && p3D == true && p4D == false)
        {
            //p4win
            panel.SetActive(true);
            winner.text = "Winner : Player4";
        }
        else if(p1D == false && p2D == true && p3D == true && p4D == true)
        {
            //p1win
            panel.SetActive(true);
            winner.text = "Winner : Player1";
        }
        else if(p1D == true && p2D == false && p3D == true && p4D == true)
        {
            //p2win
            panel.SetActive(true);
            winner.text = "Winner : Player2";
        }
        else if (p1D == true && p2D == true && p3D == false && p4D == true)
        {
            //p3win
            panel.SetActive(true);
            winner.text = "Winner : Player3";
        }
    }
}
