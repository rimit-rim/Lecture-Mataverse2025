// 카메라가 플레이어의 y좌표(세로 위치)를 따라다니도록 만드는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        // 씬 안에 있는 "cat"이라는 이름의 오브젝트를 찾아서 player에 저장
        this.player = GameObject.Find("cat");
    }

    void Update()
    {
        // 카메라의 x/z 위치는 그대로 두고, y 위치만 플레이어와 일치시킴
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}
