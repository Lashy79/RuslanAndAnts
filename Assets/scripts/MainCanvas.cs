using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainCanvas : MonoBehaviour
{

    public static Canvas CurentCanvas;
    private void Awake()
    {
        CurentCanvas = this.gameObject.GetComponent<Canvas>();
    }
}
