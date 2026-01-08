using UnityEngine;

public class E08 : MonoBehaviour
{
    public int number;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            print(number * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
