using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting ; //Mặc định là false
    [SerializeField] protected Transform bulletPrefab;



    private void Update()
    {
        AllowShoot();
        Shooting();
    }

    private void AllowShoot()
    {
        isShooting = InputManager.GetInstance.OnFiring == 1; //isShooting được cập nhật = cách kiểm tra người dùng có nhấn chuột hay không với 0 (true) và 1 (false)
    }

    private void Shooting()
    {
        if (!isShooting) return; //Nếu đúng điều kiện thì không chạy bất cứ câu lệnh nào bên dưới, nếu sai điều kiện thì chạy các câu lệnh bên dưới
        Debug.Log("Shooting");

        //Sinh ra viên đạn tại vị trí của con tàu, và góc viên đạn bắn ra chính là góc của con tàu đang bay
        Vector3 bulletSpawnPos = transform.parent.position;
        Quaternion bulletSpawnRot = transform.parent.rotation;

        Instantiate(bulletPrefab, bulletSpawnPos, bulletSpawnRot);
    }
}
