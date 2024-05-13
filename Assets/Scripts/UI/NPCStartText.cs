using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class NPCStartText : MonoBehaviour
{
    [SerializeField]
    private GameObject npcStartBox;
    [SerializeField]
    private GameObject npcScriptBox;
    int player = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == player && !npcScriptBox.activeSelf)
            npcStartBox.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == player)
        {
            npcStartBox.SetActive(false);
            npcScriptBox.SetActive(false);
        }
    }

    public void NPCScriptBoxOn()
    {
        npcStartBox.SetActive(false);
        npcScriptBox.SetActive(true);
    }
    public void NPCScriptBoxExit()
    {
        npcScriptBox.SetActive(false);
    }
}
