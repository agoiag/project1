using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class Start_sprit : MonoBehaviour
{
    public TextMeshProUGUI nameText, descText;
    public Image chrimage, bgimage;
    public Button chi1, chi2, chi3;
    public GameObject chiBtn1, chiBtn2, chiBtn3;
    int descId;

    private void Start()
    {
        chiBtn1.SetActive(false);
        chiBtn2.SetActive(false);
        chiBtn3.SetActive(false);
        descId = 0;
        //descText.text = (string)DataManager.Instance.talkTable[descId]["Desc"];
        PlayDesc(descId);
    }
    private int nextIndex = -1;
    public void PlayDesc(int descIndex)
    {
        string descString = (string)DataManager.Instance.talkTable[descIndex]["Desc"];
        string nameString = (string)DataManager.Instance.talkTable[descIndex]["Name"];
        string imageString = (string)DataManager.Instance.talkTable[descIndex]["ChrImage"];
        string bgString = (string)DataManager.Instance.talkTable[descIndex]["BGImage"];
        // chrimage.sprite = imageString;
        chrimage.sprite = Resources.Load<Sprite>(imageString);
        bgimage.sprite = Resources.Load<Sprite>(bgString);
        descText.text = descString;
        nameText.text = nameString;
        if (nextIndex > 0)
        {
            nextIndex = (int)DataManager.Instance.talkTable[descIndex]["Nextid"] - 1;
        }
        else if(nextIndex == 0)
        {
            string cString = (string)DataManager.Instance.choisetable[descIndex]["Desc"];
            descText.text = cString;
        }


    }
    public void OnClickNextDesc()
    {
        if(descId == 14)
        {
            chiBtn1.SetActive(true);
            chiBtn2.SetActive(true);
            chi1.onClick.RemoveAllListeners();
            chi2.onClick.RemoveAllListeners();
            chi1.onClick.AddListener(() => OnSelect(15));
            chi2.onClick.AddListener(() => OnSelect(19));
            chiBtn1.SetActive(false);
        } 
        else if (descId == 36)
        {
            chiBtn1.SetActive(true);
            chi1.onClick.RemoveAllListeners();
            //chi1.onClick.AddListener(() => OnSelect(37));
            chiBtn1.SetActive(false);
        }
        PlayDesc(nextIndex);
    }

    private void OnSelect(int v)
    {
        throw new NotImplementedException();
    }

    // void OnSelect(int id) { descId 대사 출력 }
}