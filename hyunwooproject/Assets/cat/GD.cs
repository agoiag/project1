using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor.UI;


public class GD : MonoBehaviour
{
    public GameObject car; // "car"��� :GameObject"�� ���� ����
    public GameObject flag;
    public GameObject distance;

    void Start()
    {
        //GameObject.Find("���̾��Ű�� "�����ִ�" ������Ʈ �̸�);
        // ������Ʈ�� �� �̸����� ã�� ���
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }
    float flagPosX;
    void Update()
    {
        //Start()���� flag, car�� ã����.
        //GameObject.tansform.position =
        // �� ������Ʈ�� ��ġ ����(��ǥ��)�� �޾ƿ�
        float length = flag.transform.position.x - car.transform.position.x;    //.x > xyz�� x�� �޾ƿ��ڴ�.
        distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";  //F2 : �Ҽ��� 2°�ڸ����� ������.
    }
}
