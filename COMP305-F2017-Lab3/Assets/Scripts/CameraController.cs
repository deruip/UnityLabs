using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Transform camTrans;
    private UnityEngine.Camera camSize;
    public Transform player;

    // Use this for initialization
    void Start()
    {
        camTrans = this.transform;
        camSize = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > -14 && player.position.x < 15.45)
        {
            camTrans.position = new Vector3(player.position.x, player.position.y, camTrans.position.z);
            camSize.orthographicSize = 5.0f;
        }
        else if (player.position.x >= 15.45 && player.position.x < 53.8)
        {
            camTrans.position = new Vector3(35f, 3.4f, camTrans.position.z);
            camSize.orthographicSize = 9.5f;
        }
        else if (player.position.x >= 53.8)
        {
            camTrans.position = new Vector3(player.position.x, player.position.y, camTrans.position.z);
            camSize.orthographicSize = Mathf.Clamp(90 - player.position.x, 2, 35);
        }
    }
}
