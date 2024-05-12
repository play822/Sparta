using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DataManager : MonoBehaviour
{ 
    public TMP_InputField playernameInput;
    public string playername;
    public int playerid = 1;
    public DataManager instance = null;


    void Awake()
    {
        DontDestroyOnLoad(this);

        if(instance != null)
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerid = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDataSave()
    {
        playername = playernameInput.text;
    }
}
