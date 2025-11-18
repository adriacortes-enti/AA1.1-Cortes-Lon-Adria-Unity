using UnityEngine;

public class E33 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1;
        Vector3 dir = new Vector3(1, 1, 0);
        Quaternion rdir = Quaternion.Euler(0, 0, 1);

        transform.position += dir * speed * Time.deltaTime;
    }
}
