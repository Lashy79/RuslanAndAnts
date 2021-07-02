using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float HP;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        var tempAmmo = collision.collider.gameObject.GetComponent<attack>();
        if (tempAmmo != null)
        {
            HP -= 100;
            if (HP < 0)
            {
               
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
