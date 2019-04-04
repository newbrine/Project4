using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2D : MonoBehaviour
{
    public GameObject sprite;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - sprite.transform.position;
    }


    void LateUpdate()
    {
        transform.position = sprite.transform.position + offset;
    }
}
