using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{
    //��ƴ� ���� ���� ���ϸ� �۷ι�(�ƹ������� ����)�̿��� ����?
    //���� ����(local) ���� ����������
    //���� ���� - public int
    [HideInInspector]
    public int testValue = 1;

    public Image bg;

    //[SerializeField]
    //Color _color;

    bool isChnged;

    Sprite test_01;//�⺻���� �Ǿ� �ִ� �̹���
    
    [SerializeField]
    Sprite test_02;// ���� ��ų �̹���

    [SerializeField]
    TextMeshProUGUI _text;

    void Start()
    {
        test_01= bg.sprite;


      //Debug.Log(testValue);
    }


    public void ChangeColor()
    {
        if(!isChnged)
        {
            bg.sprite = test_02;
            _text.text = "eeeeeeeeeeee";

            isChnged = true;
        }
        else
        {
            bg.sprite = test_01;
            _text.text = "222222222222";
            isChnged = false;
        }

        
    }


}
