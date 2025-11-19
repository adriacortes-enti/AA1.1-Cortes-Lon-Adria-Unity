using UnityEngine;

public class E17 : MonoBehaviour
{
    public Vector3 target = new Vector3 (-9, -5, 0);
    public float speed = 1; //para que no se mueva instantaneo

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + target * speed;
    }
}
