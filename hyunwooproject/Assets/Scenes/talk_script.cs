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
    //�迭
    //���� ������ Ÿ���� ������ ���� ���� ������ ��.
    //�ٵ� �迭�� ũ�Ⱑ ������ ����.

    //�迭 ���� ���
    //dataType[] �迭 �̸� = new dataType[size];
    //dataType[] �迭 �̸� = {���1, ���2, ���3,...};

    //�迭�� 0���� ����

    /*string[] descTextList =
     * { "�ȳ�.",
     * "�� �̸��� �������̾�."
     * "�� ��������."
     * "�����ϴ� �� ����� ���̴�?"
     * �׷� ������ �ϵ���"
     * );
     */

    /*descText.text = descTextList[descNum];
    descTextList��� �迭�� descNum��°�� �ش��ϴ�
    ���� descText.Text�� �ְڴ�.
    */


    /*������Ʈ�� ���� �Լ���?
    gameObject.SetActive(false)
    Ű�°�?
    gameObject.SetActive(true)

    ���� GameObject aaaa�� ��Ƴ��� ������Ʈ��
    aaaa.SetActive(true/false);
    �ƴϸ�
    aaaa.gameObject.SetActive(true/false);

    C#���� ���ڵ��� �����ϴ� ���
    �� ��ƿ����� ..�� ����߾���
    C#�� + �� �����
    �� ���� + ����/����/�������� �����ϰ� ������
    �� string_1 + string/number/var;�� ������
    �� ���ڰ� ����
    �� �� ���� object.text = ���⿡ ������ ��.
    */

    /*[SerializeField]
     * int[] testarray = new int[5];
     * ���� ���� 5ĭ�� �迭��.
     * �׷��� ���� �� �ȳ־��ָ�?
     * �׷���
     * ����Ʈ �� �Ⱦ��Ÿ� 0 or -1�� �־� �ذ���.
     * ������ ������ ����ϱ�.
     * �ڵ� �� �Ǵ��� �� �� ���� �Ǵ��ϴϱ�.
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
        descText.text = "�ȳ�.";
    }
    else if (descNum == 1)
    {
        descText.text = "�� �̸��� �������̾�.";
    }
    else if (descNum == 2)
    {
        descText.text = "�� ��������.";
    }
    else if (descNum == 3)
    {
        descText.text = "�����ϴ� �� ����� ���̴�?";
    }
    else if (descNum == 4)
    {
        descText.text = "�׷� ������ �ϵ���";
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