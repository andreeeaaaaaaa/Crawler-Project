using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3 (0,3.5f,-3.2f);

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
