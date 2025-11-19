using UnityEngine;

public class E16 : MonoBehaviour
{
    public Vector3 target = new Vector3 (9, -5, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + target;
    }
}
