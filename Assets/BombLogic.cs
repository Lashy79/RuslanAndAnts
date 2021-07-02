using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLogic : MonoBehaviour
{
    [SerializeField] private float Minran, Maxran;
    private float ran;

    [SerializeField] private ParticleSystem Booom;

    void Start()
    {
      ran = Random.Range(Minran, Maxran);
      Destroy(this.gameObject,ran);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Time.deltaTime < Maxran )
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            Instantiate(Booom, this.transform.position, new Quaternion());
        }
    }
    
}
