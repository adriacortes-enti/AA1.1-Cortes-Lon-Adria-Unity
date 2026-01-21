using UnityEngine;
using UnityEngine.SceneManagement;
public class E67 : MonoBehaviour
{
    public GameObject musicPlayer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) //load red
        {
            DontDestroyOnLoad(musicPlayer);
            SceneManager.LoadScene("E67_BLUE");
        }

     
    }


}
