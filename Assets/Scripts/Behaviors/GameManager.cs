using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DataManager dataManager;
    public GameObject character1;
    public GameObject character2;
    public GameObject Target { get; set; }

    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null)
            instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        dataManager = DataManager.instance;
        if (dataManager == null)
        {
            Debug.Log("데이타 매니져가없습니다.");
            return;
        }
        if(dataManager.playerid == 1)
        {

            Target = Instantiate(character1);
          
        }
        else
        {
            Target = Instantiate(character2);
        }

    }

    // Update is called once per frame
}
