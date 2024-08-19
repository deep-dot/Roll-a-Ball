using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // Declare the player as a GameObject
    private Vector3 offset;   // Declare the offset as a Vector3

    void Start()
    {
        // Calculate the initial offset between the camera and the player
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Set the camera's position to follow the player, maintaining the offset
        transform.position = player.transform.position + offset;
    }
}
