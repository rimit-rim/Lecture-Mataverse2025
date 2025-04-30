// 오브젝트에 힘(force) 을 가해 앞으로 날아가게 하는 스크립트
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void Start()
    {
        Shoot(new Vector3(0, 200, 2000));
    }
}
