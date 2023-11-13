using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform sprite;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(sprite.position.x, sprite.position.y, transform.position.z);
    }
}
