using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPos;
    protected float speedMove;

    private void Start()
    {
        speedMove = 0.1f;
    }

    private void FixedUpdate()
    {
        worldPos = InputManager.GetInstance.MouseWorldPos;
        worldPos.z = 0;

        Vector3 newPos = Vector3.Lerp(transform.parent.position, worldPos, speedMove);
        transform.parent.position = newPos;
    }
}
