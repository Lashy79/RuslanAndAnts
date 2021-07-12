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
        StartCoroutine(Boooom()) ;
    }

    // Update is called once per frame
    void Update()
    {
       if (Maxran < 1)
        {

        }
       
    }
    
    private IEnumerator Boooom()
    {
        yield return new WaitForSeconds(ran-0.1f);
        Instantiate(Booom, this.transform.position, Quaternion.identity);
  
    }
    
}
