using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControll : MonoBehaviour
{
    public int speed;
    public KeyCode leftKey;
    public KeyCode rightKey;
    private Rigidbody rig;
    public bool paddleX = false;
    public bool paddleY = false;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(GetInput());
    }

    private Vector3 GetInput()
    {
        if(Input.GetKey(leftKey))
        {
            if(paddleX == true)
            {
                return Vector3.left * speed;
            }
            else if(paddleY == true)
            {
                return Vector3.forward * speed;
            }
            
        }
        else if(Input.GetKey(rightKey))
        {
            if(paddleX == true)
            {
                return Vector3.right * speed;
            }
            else if(paddleY == true)
            {
                return Vector3.back * speed;
            }
            
        }
        return Vector3.zero;
    }

    private void MovePaddle(Vector3 movement)
    {
        rig.velocity = movement;
    }
}
