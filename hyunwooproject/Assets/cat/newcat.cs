using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newcat : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 왼쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(transform.position.x > -9)
            {
                transform.Translate(-3, 0, 0);            // 왼쪽으로 「3」 움직인다
            }

        }

        // 오른쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if((transform.position.x < 9))
            {
                transform.Translate(3, 0, 0); // 오른쪽으로 「3」 움직인다
            }
          
        }

    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}


