using UnityEngine;
using UnityEngine.InputSystem;

public class E58 : MonoBehaviour
{
    bool normalGravity = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.IsPressed())
        {
            if (normalGravity == true)
            {
                Physics2D.gravity = new Vector2(0, 9.8f);
                normalGravity = false;
            }
            else 
            {
                Physics2D.gravity = new Vector2(0, -9.8f);
                normalGravity = true;
            }
        }
    }
}
