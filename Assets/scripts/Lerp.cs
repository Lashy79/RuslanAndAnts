using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    //���������� ������� �� ��������
    [SerializeField]//���� ����� � ����������, �� �� ������ ������� �� �����. �������� - �����)
    private Transform LerpPos;

    [SerializeField]
    private float speed;

    void Update()
    {
        var interpolate = Vector3.Lerp(this.transform.position, LerpPos.position, speed*Time.deltaTime);
        interpolate.z = this.transform.position.z;
        this.transform.position = interpolate;

    }
}
