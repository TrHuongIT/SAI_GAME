using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    private float moveSpeed = 10f;
    private Vector3 direction = Vector3.right;

    private void Update()
    {
        transform.parent.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
