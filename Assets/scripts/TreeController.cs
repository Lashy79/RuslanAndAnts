using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    public Animator mator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public float vstate, hstate;
    public float InterpolatedVState, InterpolatedHState;
    public float step;
    private Vector3 prevPos;
    void Update()
    {
        vstate = Input.GetAxis("Vertical");
        hstate = Input.GetAxis("Horizontal");

        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    vstate = Input.GetAxis("Vertical") * 2;
        //}
        



      //  mator.SetFloat("VSpeed", (transform.position.y - prevPos.y) * 10);
        prevPos = transform.position;


        InterpolatedVState += (vstate - InterpolatedVState) * Time.deltaTime * step;
        InterpolatedHState += (hstate - InterpolatedHState) * Time.deltaTime * step;

        mator.SetFloat("Vertical", InterpolatedVState);
        mator.SetFloat("Horizontal", InterpolatedHState);
    }
}

