using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class E26 : MonoBehaviour
{
    private Vector2 thrust = new Vector2(0, 6);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(thrust, ForceMode2D.Impulse);
        }
    }
}
