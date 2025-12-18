using System;
using Unity.VisualScripting;
using UnityEngine;

public class E62Portal : MonoBehaviour
{
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = target.transform.position;
        
    }
}
