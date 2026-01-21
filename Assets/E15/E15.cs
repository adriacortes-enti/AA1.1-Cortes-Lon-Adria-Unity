using UnityEngine;
public class E15 : MonoBehaviour
{
    int playerA;
    int playerB;

    int winsA;
    int winsB;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            playerA = Random.Range(1,4);
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
                winsB++;
            }
            if (playerA == 1 && playerB == 3)
            {
                Debug.Log("playerA ha jugado Piedra");
                Debug.Log("playerB ha jugado Tijeras");
                Debug.Log("Gana playerA");
                winsA++;
            }
            if (playerA == 2 && playerB == 1)
            {
                Debug.Log("playerA ha jugado Papel");
                Debug.Log("playerB ha jugado Piedra");
                Debug.Log("Gana playerA");
                winsA++;
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
                winsB++;
            }
            if (playerA == 3 && playerB == 1)
            {
                Debug.Log("playerA ha jugado Tijera");
                Debug.Log("playerB ha jugado Piedra");
                Debug.Log("Gana playerB");
                winsB++;
            }
            if (playerA == 3 && playerB == 2)
            {
                Debug.Log("playerA ha jugado Tijera");
                Debug.Log("playerB ha jugado Papel");
                Debug.Log("Gana playerA");
                winsA++;
            }
            if (playerA == 3 && playerB == 3)
            {
                Debug.Log("playerA ha jugado Tijera");
                Debug.Log("playerB ha jugado Tijera");
                Debug.Log("Empate");
            }
        }

        if (winsA > winsB)
        {
            Debug.Log("Ha ganado playerA");
        }else if (winsA < winsB)
        {
            Debug.Log("Ha ganado playerB");
        }else
        {
            Debug.Log("Nadie ha ganado");
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
