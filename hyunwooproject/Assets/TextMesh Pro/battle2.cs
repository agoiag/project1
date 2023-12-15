using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Authentication.ExtendedProtection;

public class battle2 : MonoBehaviour
{
    [SerializeField]
    int descNum;
    public GameObject BG;
    public GameObject BBG;
    public GameObject TBG;
    public GameObject PC;
    public GameObject NPC;
    public GameObject BPC;
    public GameObject BNPC;
    public Button Back;
    public Button Atk;
    public Button Normal;
    public Button skill;
    public Button item;
    public Button potion;
    public Button run;
    public GameObject TG;
    public GameObject PCTrun;
    public GameObject NPCTrun;
    public GameObject PCHP;
    public GameObject NPCHP;

    public void ChangeDesc()
    {
        switch (descNum)
        {
            case 0:
                {
                    BBG.SetActive(true);
                    PCTrun.SetActive(true);
                    PC.gameObject.SetActive(false);
                    NPC.gameObject.SetActive(false);
                    TBG.SetActive(true);
                    Atk.gameObject.SetActive(true);
                    item.gameObject.SetActive(true);
                    run.gameObject.SetActive(true);
                }
                break;
            case 1:
                { 
                                    
                }
                break;

        }
     descNum++;




        }








    }

