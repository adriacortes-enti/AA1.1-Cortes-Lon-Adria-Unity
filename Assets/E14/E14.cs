using UnityEngine;

public class E14 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                int result = i * j;
                Debug.Log(result);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
