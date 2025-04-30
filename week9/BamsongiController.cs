// 충돌 시 이펙트 발생 및 멈춤 기능만을 담당하며, 초기 자동 발사 기능은 제거된 상태
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    void Start()
    {
        // Shoot(new Vector3(0, 200, 2000));
    }
}
