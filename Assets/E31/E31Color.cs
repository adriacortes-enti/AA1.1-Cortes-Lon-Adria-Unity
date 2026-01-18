using UnityEngine;

public class E31Color : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        spriteRenderer.color = new Color(255, 0, 0);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        spriteRenderer.color = new Color(255, 255, 255);
    }
}
