using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.GraphicsBuffer;

public class Chasing : MonoBehaviour
{
    public Vector3 adjustCamPos;
 
    private GameObject target;

    // 카메라 경계 설정
    public Vector2 minCamLimit;
    public Vector2 maxCamLimit;

    
    public float CameraZ = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        target = GameManager.instance.Target;
        Vector3 TargetPos = new Vector3(target.transform.position.x, target.transform.position.y, CameraZ);
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime *2f);
        transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, minCamLimit.x, maxCamLimit.x) + adjustCamPos.x,
        Mathf.Clamp(transform.position.y, minCamLimit.y, maxCamLimit.y) + adjustCamPos.y,
        -10f + adjustCamPos.z);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
