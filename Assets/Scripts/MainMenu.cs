using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        // je nach dem wie du mit dem script weiterverfährt,
        // der build index wird mit jedem replay um eins erweitert,
        // du hast aber gerade nur eine szene, deswegen ist es etwas
        // gefährlich dies hier zu nutzen, besser auf ein array verweisen,
        // oder bis du mehrere szenen hast, gezielt die szenen ansprechen. 
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        // always load the second scene when using button play
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit the Game");
    }
}
