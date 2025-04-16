// 자동차(car)가 목표 지점(flag)까지 얼마나 남았는지를 화면에 텍스트로 보여주는 스크립트
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI를 사용하는 데 필요하다
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;	// 자동차
    GameObject flag;	// 목표지점
    GameObject distance;	// 남은 거리를 표시할 UI 텍스트

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        // 자동차와 깃발의 x좌표 차이를 계산하여 length에 저장
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        // length 값을 소수점 둘째자리까지 포맷 문자열로 바꾸고 UI 텍스트에 표시
        this.distance.GetComponent<TextMeshProUGUI>().text = "Distance: " + length.ToString("F2") + "m";
         }
    }
