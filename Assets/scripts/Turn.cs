using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 Diff = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       // Diff = Vector3.Normalize(Diff - transform.position);
        //transform.forward = Diff;
           float rotateZ = Mathf.Atan2(Diff.y, Diff.x) * Mathf.Rad2Deg;
         float rotateZ1 = Mathf.Atan(Diff.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);
        Debug.DrawRay(transform.position, Diff);
        
    }
}
