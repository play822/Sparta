using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.TextCore.Text;
using UnityEditor.Experimental.GraphView;

public class InGameSelect : MonoBehaviour
{
    // Start is called before the first frame update
    GameManager gameManager;
    DataManager dataManager;
     public void SelectCharacteron()
    {
        this.gameObject.SetActive(true);
        dataManager = DataManager.instance;
        gameManager = GameManager.instance;
    }
    public void SelectCharacter1(int num)
    {
        Vector3 positon = gameManager.Target.transform.position;

        Quaternion rotation = gameManager.Target.transform.rotation;
        if (num == 1)
        {
            
            Destroy(gameManager.Target);
            gameManager.Target = Instantiate(gameManager.character1, positon, rotation);
            this.gameObject.SetActive(false);
            dataManager.playerid = 1;
        }
        else
        {
            Destroy(gameManager.Target);
            gameManager.Target = Instantiate(gameManager.character2, positon, rotation);
            this.gameObject.SetActive(false);
            dataManager.playerid = 2;
        }
    }
   
}
