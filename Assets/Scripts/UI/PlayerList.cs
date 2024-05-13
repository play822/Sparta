using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerList : MonoBehaviour
{
    public GameObject[] player;
    public List<TMP_Text> name;
    public TMP_Text text;

    public void PlayerListon()
    {
        this.gameObject.SetActive(true);
        player = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < player.Length; i++) 
        {
            name.Add(player[i].GetComponentInChildren<TMP_Text>());
        }
        for(int i = 0;i < name.Count;i++) 
        {
            text.text += (name[i].text +("\n"));
        }
    }

    public void PlayerListClose()
    {
        this.gameObject.SetActive(false);
        name.Clear();
        text.text = string.Empty;
    }
}
