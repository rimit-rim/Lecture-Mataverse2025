using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 왼쪽 화살표 입력
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0); // 왼쪽으로 3 이동
        }

        // 오른쪽 화살표 입력
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0); // 오른쪽으로 3 이동
        }

        // 위쪽 화살표 입력
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 3, 0); // 위로 이동 3 이동
        }

        // 아래쪽 화살표 입력
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -3, 0); // 아래로 이동 3 이동
        }
    }
}