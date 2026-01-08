using UnityEngine;

public class E07 : MonoBehaviour
{
    public int numberA;
    public int numberB;
    public string operation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (operation == "+")
        {
            print(numberA + numberB);
        }
        else if (operation == "-")
        {
            print(numberA - numberB);
        }
        else if (operation == "*")
        {
            print(numberA * numberB);
        }
        else if (operation == "/")
        {
            print(numberA / numberB);
        }
        else if (operation == "%")
        {
            print(numberA % numberB);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
