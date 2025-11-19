using UnityEngine;

public class E06 : MonoBehaviour
{
    public int numberA;
    public int numberB;
    public int numberC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((numberA + numberB + numberC) / 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
