using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager GetInstance { get => instance; }

    [SerializeField] private Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get => mouseWorldPos; }

    private float onFiring;
    public float OnFiring { get => onFiring;}


    private void Awake()
    {
        if (instance != null) Debug.LogError("Chỉ có 1 InputManager!");

        instance = this;
    }

    private void Update()
    {
        onFiring = Input.GetAxis("Fire1");
    }

    private void FixedUpdate()
    {
        GetMousePos();
    }

    protected virtual void GetMousePos()
    {
        mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
