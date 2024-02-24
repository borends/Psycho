using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float RotationSpeed = 5f;
    public Transform CameraAxisTranform;
    public float minValue;
    public float maxValue;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localEulerAngles = new Vector3 (0f, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0f);
        var newAngleX = CameraAxisTranform.localEulerAngles.x - Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse Y");
        if (newAngleX > 180)
        {
            newAngleX -= 360;
        }
        newAngleX = Mathf.Clamp(newAngleX, minValue, maxValue);
        CameraAxisTranform.localEulerAngles = new Vector3 (newAngleX, 0f, 0f);
    }
}
