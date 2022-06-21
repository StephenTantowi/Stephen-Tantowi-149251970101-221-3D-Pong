using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public List<GameObject> spawn;
    public int jumBall = 0;
    public GameObject ball;
    private float timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumBall = GameObject.FindGameObjectsWithTag("Ball").Length;
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnRandomBall();
            timer = 5;
        }    
    }
    private void SpawnRandomBall()
    {
        int rnd = Random.Range(0, spawn.Count);
        if(jumBall <= 5)
        {
            Instantiate(ball, spawn[rnd].transform.position, Quaternion.identity);
        }
    }    
}
