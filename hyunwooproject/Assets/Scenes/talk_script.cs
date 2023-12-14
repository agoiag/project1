using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using static System.Net.Mime.MediaTypeNames;

public class talk_script : MonoBehaviour
{
    //배열
    //같은 데이터 타입을 가지는 여러 값을 저장해 줌.
    //근데 배열은 크기가 정해져 있음.

    //배열 선언 방법
    //dataType[] 배열 이름 = new dataType[size];
    //dataType[] 배열 이름 = {요소1, 요소2, 요소3,...};

    //배열은 0부터 시작

    /*string[] descTextList =
     * { "안녕.",
     * "내 이름은 이현승이야."
     * "난 멋쟁이지."
     * "집중하는 내 모습이 보이니?"
     * 그럼 열심해 하도록"
     * );
     */

    /*descText.text = descTextList[descNum];
    descTextList라는 배열의 descNum번째에 해당하는
    값을 descText.Text에 넣겠다.
    */


    /*오브젝트를 끄는 함수는?
    gameObject.SetActive(false)
    키는건?
    gameObject.SetActive(true)

    만약 GameObject aaaa로 담아놓은 오브젝트면
    aaaa.SetActive(true/false);
    아니면
    aaaa.gameObject.SetActive(true/false);

    C#에서 문자들을 연결하는 방법
    ㄴ 루아에서는 ..을 사용했었음
    C#은 + 를 사용함
    ㄴ 문자 + 문자/숫자/변수값을 연결하고 싶으면
    ㄴ string_1 + string/number/var;로 적으면
    ㄴ 문자가 나옴
    ㄴ 그 값을 object.text = 여기에 넣으면 됨.
    */

    /*[SerializeField]
     * int[] testarray = new int[5];
     * 위에 놈은 5칸의 배열임.
     * 그래서 따로 값 안넣어주면?
     * 그래서
     * 퀘스트 때 안쓸거면 0 or -1로 넣어 준거임.
     * 없으면 문제가 생기니까.
     * 코드 상 판단을 할 때 값을 판단하니까.
     */

    /*GameObject[]testGame = new GameObject[10];
     * Image[] testImage = new Image[10];
    */






    int descNum;
public TextMesh descText;
public Button startBtn;
public GameObject textBg;
public GameObject Bg;

public void ChangeDesc()
{
    if (descNum == 0)
    {
        textBg.SetActive(true);
        startBtn.gameObject.SetActive(false);
        descText.text = "안녕.";
    }
    else if (descNum == 1)
    {
        descText.text = "내 이름은 이현승이야.";
    }
    else if (descNum == 2)
    {
        descText.text = "난 멋쟁이지.";
    }
    else if (descNum == 3)
    {
        descText.text = "집중하는 내 모습이 보이니?";
    }
    else if (descNum == 4)
    {
        descText.text = "그럼 열심히 하도록";
    }
    if (descNum == 5)
    {
        textBg.SetActive(false);
        Bg.SetActive(true);
    }

    else
    {
        descNum++;

        if (descNum == 6)
        {
            textBg.SetActive(true);
            descText.text = "asdf.";
        }

        else if (descNum == 7)
        {
            descText.text = "ASGAG.";
        }
        else if (descNum == 8)
        {
            descText.text = "ASDFDHBGH.";
        }
        else if (descNum == 9)
        {
            descText.text = "ASDFSAGGREAG.";
        }
        else if (descNum == 10)
        {
            descText.text = "AASRHHERRJJYYJTYY.";
        }
        if (descNum == 11)
            descNum = 0;
        else
        {
            descNum++;
        }
    }
}
}