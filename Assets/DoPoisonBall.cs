using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoPoisonBall : MonoBehaviour
{
    public ParticleSystem Ball;
    public Transform BallPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(Ball, BallPos.position, Ball.transform.rotation);
        }

    }
}
