using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameD : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject GameOver;
    void Start()
    {
        hpGauge = GameObject.Find("HPgauge");
    }

    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f; // 맞을 때마다체력 게이지가 0.1씩 깎여나감.
        if(hpGauge.GetComponent<Image>().fillAmount == 0)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void ReStart()
    {
        hpGauge.GetComponent<Image>().fillAmount = 1f;
        GameOver.SetActive(false);
        Time.timeScale = 1;
    }
}
