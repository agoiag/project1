using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class Study_01 : MonoBehaviour
{
    // Start is called before the first frame update
    int test;
    /*   void Awake()
       {
       Debug.LogError("Awake");
       }
       void FixedUpdate()
       {
       Debug.LogWarning("FixedUpdate");
       }
       void LateUpdate()
       {
           Debug.LogError("LogError");
       }
    */
    void Start()
    {
        Debug.Log("start");


        //강화 등 한단계씩 올라갈 때 사용할 수 있음
        /*    Debug.Log(test);
            test++;
            Debug.Log(test);
            test += 1;
            Debug.Log(test);
            test = test + 1;
            Debug.Log(test);

            Debug.Log("노현우");
            Debug.LogWarning("경고");
            Debug.LogError("에러");
        */
    }
    void OnEnable()//활성화 될 때
    {
        Debug.Log("켜졌다");
    }
    void OnDisable()//비활성화 될때
    {
        Debug.Log("꺼졌다");
    }
    void OnDestroy()
    {
        Debug.Log("으악! 범인은 박민수...");
    }

    //lua = nil
    //c# = null
    // 이게 주석 한줄이다.

    /* 이게 주석 여러줄
     *업데이트는 매 프레임마다 실행
     * test += 3; < test에 3을 더한 값이 test라는 표시
     * crtl+d > 커서가 위치한 열 복사
     * ;는 마침표 역할을 함.
     * ㅁㄴㅇㄹ아래처럼 별 슬래시 치면 주석
     */



    // Update is called once per frame

    void Update()
    {
        
        // Debug.Log("Update");    

    }
}