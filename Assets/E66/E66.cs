using UnityEngine;
using UnityEngine.SceneManagement;
public class E66 : MonoBehaviour
{
    public void ClickButton() //loads BLUE
    {
        
        SceneManager.LoadScene("E66_BLUE");
    }

    void Start()
    {
        Invoke("GreenScene", 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) //load red
        {
            SceneManager.LoadScene("E66_RED");
        }

     
    }

    void GreenScene()
    {
        SceneManager.LoadScene("E66_GREEN");
    }
}
