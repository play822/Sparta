using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DataManager dataManager;
    public GameObject character1;
    public GameObject character2;
    // Start is called before the first frame update
    void Start()
    {
        dataManager = FindObjectOfType<DataManager>();
        if (dataManager == null)
        {
            Debug.Log("����Ÿ �Ŵ����������ϴ�.");
            return;
        }
        if(dataManager.playerid == 1)
        {
            Instantiate(character1);
        }
        else
        {
            Instantiate(character2);
        }

    }

    // Update is called once per frame
}
