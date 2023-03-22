using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Transform playerT;

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(playerT.position.x,playerT.position.y +2 ,transform.position.z);
    }
}
