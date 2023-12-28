using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : Singleton<DataManager>
{
    public List<Dictionary<string, object>> talkTable;
    public List<Dictionary<string, object>> selectTable;
    public List<Dictionary<string, object>> battleTable;

    private void Awake()
    {
        talkTable = CSVReader.Read("talk_table");
        selectTable = CSVReader.Read("select_table");
        battleTable = CSVReader.Read("battle_table");
    }
}
