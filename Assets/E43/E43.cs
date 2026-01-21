using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class E43 : MonoBehaviour
{
    Vector3 direction = new Vector3 (0, 0, 0);
    public float speed = 1; //para que no se mueva instantaneo
    public TextMeshProUGUI Text;
    int counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
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

        transform.Translate( direction * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        counter++;
        Text.text = counter.ToString();
    }

}
