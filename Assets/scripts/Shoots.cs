using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Fire;
    public float stregs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var spawnedFire = GameObject.Instantiate(Fire, SpawnPoint.position, new Quaternion());
          
            var RB = spawnedFire.GetComponent<Rigidbody2D>();
            if (RB != null)
            {
                Vector3 CudaPulat = SpawnPoint.forward;
                RB.AddForce(CudaPulat * stregs, ForceMode2D.Impulse);

            }
        }
    }
}
    

