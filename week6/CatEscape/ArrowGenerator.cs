// 일정 시간마다 랜덤 위치에서 화살(Arrow)을 생성하는 역할
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;	// 생성할 화살 프리팹
    float span = 1.0f;	// 화살 생성 주기
    float delta = 0;		// 흐른 시간 누적 타이머

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)	// 1초마다 한 번 실행
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);   	// 프리팹에서 새 화살 생성
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
