// 자동차를 마우스 클릭으로 출발시키고, 점점 느려지게 하는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))        // 왼쪽 마우스를 클릭하면
        {
            this.speed = 0.2f;                  // 처음 속도를 설정 (0.2)
        }

        transform.Translate(this.speed, 0, 0);  // 현재 속도만큼 이동 (x축)
        this.speed *= 0.98f;                    // 감속
    }
}
