using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Start_sprit : MonoBehaviour
{
    public TextMeshProUGUI nameText, descText;
    int descId;

    private void Start()
    {
        descId = 0;
        descText.text = (string)DataManager.Instance.talkTable[descId]["Desc"];
    }
}
