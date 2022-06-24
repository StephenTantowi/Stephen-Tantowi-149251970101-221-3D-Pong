using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public ScoreManager manager;
    public bool p1;
    public bool p2;
    public bool p3;
    public bool p4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            if (p1 == true)
            {
                manager.MinScoreP1(1);
            }
            else if (p2 == true)
            {
                manager.MinScoreP2(1);
            }
            else if(p3 == true)
            {
                manager.MinScoreP3(1);
            }
            else if(p4 == true)
            {
                manager.MinScoreP4(1);
            }
        }
    }
}
