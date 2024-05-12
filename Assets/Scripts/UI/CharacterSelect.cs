using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public GameObject resultPanel;
    public GameObject Panel;
    public DataManager playerdata;
    // Start is called before the first frame update
    public void ResultPanelSatart()
    {
        resultPanel.SetActive(true);
    }

    public void CharacterSelect1()
    {
        GameObject character1 = Panel.transform.GetChild(0).gameObject;
        GameObject character2 = Panel.transform.GetChild(1).gameObject;
        character1.SetActive(true);
        character2.SetActive(false);
        resultPanel.SetActive(false);
        playerdata.playerid = 1;
    }

    public void CharacterSelect2()
    {
        GameObject character1 = Panel.transform.GetChild(0).gameObject;
        GameObject character2 = Panel.transform.GetChild(1).gameObject;
        character1.SetActive(false);
        character2.SetActive(true);
        resultPanel.SetActive(false);
        playerdata.playerid = 2;
    }

    public void StartButton()
    {
        if(playerdata.playername.Length >= 2 && playerdata.playername.Length <= 10) 
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

}
