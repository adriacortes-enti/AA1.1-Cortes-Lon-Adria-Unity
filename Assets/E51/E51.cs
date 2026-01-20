using UnityEngine;
using UnityEngine.InputSystem;

public class E51 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z, transform.rotation.w);
        }
        if (Mouse.current.rightButton.isPressed)
        {
            transform.rotation = new Quaternion(transform.rotation.x + 180, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        }
    }
}
