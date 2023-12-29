using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : Singleton<DataManager>
{
    public List<Dictionary<string, object>> talkTable;
    public List<Dictionary<string, object>> choisetable;
    public List<Dictionary<string, object>> battleTable;

    private void Awake()
    {
        talkTable = CSVReader.Read("talk table");
        choisetable = CSVReader.Read("choise table");
        battleTable = CSVReader.Read("battle table");
    }
}
