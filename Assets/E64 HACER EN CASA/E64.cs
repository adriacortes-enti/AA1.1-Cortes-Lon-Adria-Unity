
using UnityEngine;
using UnityEngine.InputSystem;

public class E64 : MonoBehaviour
{
    Vector3 direction = new Vector3 (0, 0, 0);
    public float speed = 1; //para que no se mueva instantaneo
    public GameObject Clone;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction.y = 0;
        direction.x = 0;

        if (Keyboard.current.wKey.isPressed)
        {
            direction.y = 1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }

        if (Input.GetKeyDown("space")) //https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
        {
            Instantiate(Clone,transform.position, transform.rotation);
        }

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
