using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void LateUpdate() // Follow player
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, Time.deltaTime);
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
