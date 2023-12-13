using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NewBehaviourScript : MonoBehaviour
{
    //루아는 따로 정의 안하면 글로벌(아무데서나 접근)이였음 ㅇㅇ?
    //지역 변수(local) 따로 해줬을거임
    //주의 사항 - public int
    [HideInInspector]
    public int testValue = 1;

    public Image bg;

    //[SerializeField]
    //Color _color;

    bool isChnged;

    Sprite test_01;//기본으로 되어 있는 이미지
    
    [SerializeField]
    Sprite test_02;// 변경 시킬 이미지

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
