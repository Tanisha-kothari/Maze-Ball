using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotateSpeed;
    public float maxRot;

    float mouseX, mouseY;
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RotateGround();
        }
        
    }

    private void RotateGround()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");

        float rotateX = mouseX * rotateSpeed;
        float rotateZ = mouseY * rotateSpeed;

        rotateX = Mathf.Clamp(rotateX, -maxRot, maxRot);
        rotateZ = Mathf.Clamp(rotateZ, -maxRot, maxRot);

        transform.eulerAngles = new Vector3(rotateZ, transform.rotation.y, -rotateX);
    }
}
