using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor.UI;


public class GD : MonoBehaviour
{
    public GameObject car; // "car"라는 :GameObject"를 담을 변수
    public GameObject flag;
    public GameObject distance;

    void Start()
    {
        //GameObject.Find("하이어라키에 "켜져있는" 오브젝트 이름);
        // 오브젝트들 중 이름으로 찾는 방법
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }
    float flagPosX;
    void Update()
    {
        //Start()에서 flag, car를 찾았음.
        //GameObject.tansform.position =
        // 그 오브젝트의 위치 정보(좌표값)을 받아옴
        float length = flag.transform.position.x - car.transform.position.x;    //.x > xyz중 x를 받아오겠다.
        distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";  //F2 : 소수점 2째자리까지 보여줌.
    }
}
