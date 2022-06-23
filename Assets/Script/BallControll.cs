using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    public Vector3 speed;
    public Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
