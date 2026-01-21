using UnityEngine;
public class E11 : MonoBehaviour
{
    public int playerA;
    int playerB;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        playerB = Random.Range(1,4);

        if (playerA == 1 && playerB == 1)
        {
            Debug.Log("playerA ha jugado Piedra");
            Debug.Log("playerB ha jugado Piedra");
            Debug.Log("Empate");
        }
        if (playerA == 1 && playerB == 2)
        {
            Debug.Log("playerA ha jugado Piedra");
            Debug.Log("playerB ha jugado Papel");
            Debug.Log("Gana playerB");
        }
        if (playerA == 1 && playerB == 3)
        {
            Debug.Log("playerA ha jugado Piedra");
            Debug.Log("playerB ha jugado Tijeras");
            Debug.Log("Gana playerA");
        }
        if (playerA == 2 && playerB == 1)
        {
            Debug.Log("playerA ha jugado Papel");
            Debug.Log("playerB ha jugado Piedra");
            Debug.Log("Gana playerA");
        }
        if (playerA == 2 && playerB == 2)
        {
            Debug.Log("playerA ha jugado Papel");
            Debug.Log("playerB ha jugado Papel");
            Debug.Log("Empate");
        }
        if (playerA == 2 && playerB == 3)
        {
            Debug.Log("playerA ha jugado Papel");
            Debug.Log("playerB ha jugado Tijera");
            Debug.Log("Gana playerB");
        }
        if (playerA == 3 && playerB == 1)
        {
            Debug.Log("playerA ha jugado Tijera");
            Debug.Log("playerB ha jugado Piedra");
            Debug.Log("Gana playerB");
        }
        if (playerA == 3 && playerB == 2)
        {
            Debug.Log("playerA ha jugado Tijera");
            Debug.Log("playerB ha jugado Papel");
            Debug.Log("Gana playerA");
        }
        if (playerA == 3 && playerB == 3)
        {
            Debug.Log("playerA ha jugado Tijera");
            Debug.Log("playerB ha jugado Tijera");
            Debug.Log("Empate");
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
