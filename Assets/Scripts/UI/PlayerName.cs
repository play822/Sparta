using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerName : MonoBehaviour
{
    public  TMP_Text name;
    public DataManager dataManager;

    // Start is called before the first frame update
    void Start()
    {
        dataManager = FindObjectOfType<DataManager>();
        name.text = dataManager.playername;
    }

}
