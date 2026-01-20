using UnityEngine;
using UnityEngine.SceneManagement;
public class E66 : MonoBehaviour
{
    public void ClickButton() //loads BLUE
    {
        SceneManager.LoadScene("E66_BLUE");
    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetKeyDown("space")) //load red
        {
            SceneManager.LoadScene("E66_RED");
        }
    }
}
