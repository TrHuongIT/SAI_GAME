using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected Vector3 targetPos;
    protected float speedMove;

    private void Start()
    {
        speedMove = 0.05f;
    }

    private void FixedUpdate()
    {
        GEtPosition();
        LookAtTarget();
        MOving();
    }

    protected virtual void LookAtTarget()
    {
        Vector3 direction = targetPos - transform.parent.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //Sử dụng 1 trong 2 cách
        transform.parent.rotation = Quaternion.AngleAxis(angle, Vector3.forward); //Xoay trục Z 1 góc 90 độ - phù hợp với model của con tàu trong game này
        //transform.parent.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    protected virtual void GEtPosition()
    {
        targetPos = InputManager.GetInstance.MouseWorldPos;
        targetPos.z = 0;
    }

    protected virtual void MOving()
    {        

        Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPos, speedMove);
        transform.parent.position = newPos;
    }
}
