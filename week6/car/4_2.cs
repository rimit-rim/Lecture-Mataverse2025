// 스와이프 길이에 따라 출발 속도가 달라지는 방식의 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;	// 현재 자동차 속도
    Vector2 startPos;	// 마우스를 처음 눌렀을 때의 위치

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 스와이프의 길이를 구한다 (추가)
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스를 클릭한 좌표를 저장
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표를 저장
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;	// 스와이프의 거리 = 끝 - 시작

            // 스와이프 길이를 처음 속도로 변경한다
            this.speed = swipeLength / 500.0f;
        }

        transform.Translate(this.speed, 0, 0);  // 이동
        this.speed *= 0.98f;                    // 감속
    }
}
