// HP 게이지를 관리하는 컨트롤러로, 게임 중 플레이어가 데미지를 입었을 때 HP를 10% 감소시키는 역할
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 않고 추가한다

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;	// 10% 감소
    }
}
