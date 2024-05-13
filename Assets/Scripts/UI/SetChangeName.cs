using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetChangeName : MonoBehaviour
{
    public TMP_Text name;
    public TMP_InputField inputField;
    public DataManager dataManager;
    void Start()
    {
        
        dataManager = DataManager.instance;
        dataManager.playernameInput = inputField;
    }
    public void SetChangeNameOn()
    {
        this.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void SetChangeNameEnd()
    {
        
        dataManager.PlayerDataSave();
        
    }

    public void SetChangeNameClose()
    {
        if (dataManager.playername.Length >= 2 && dataManager.playername.Length <= 10)
        { 
            name = GameManager.instance.Target.GetComponentInChildren<TMP_Text>();
            name.text = dataManager.playername;
            dataManager.playernameInput.text = "닉네임을 입력해주세요";
            this.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }    
}
