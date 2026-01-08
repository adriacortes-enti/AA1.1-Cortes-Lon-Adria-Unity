using UnityEngine;

public class E13 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            print(Random.Range(0, 100));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
