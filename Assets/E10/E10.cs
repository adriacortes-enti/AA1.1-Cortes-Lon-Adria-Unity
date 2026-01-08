using UnityEngine;

public class E10 : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numberA = Random.Range(0, 10);
        int numberB = Random.Range(0, 10);
        int operation = Random.Range(1, 5);


        if (operation == 1)
        {
            print(numberA + numberB);
        }
        else if (operation == 2)
        {
            print(numberA - numberB);
        }
        else if (operation == 3)
        {
            print(numberA * numberB);
        }
        else if (operation == 4)
        {
            print(numberA / numberB);
        }
        else if (operation == 5)
        {
            print(numberA % numberB);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
