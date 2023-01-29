using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // variable für das gameobject, wo das script drauf liegt
    public GameObject gameOverCanvas;
    
    // variable für das script, welches geholt werden soll
    private OutOfBounds _outOfBoundsScript;

    // Start is called before the first frame update
    void Start()
    { 
        // Variable mit der script referenz befüllen.
        // suche nach dem game object wo das script drauf liegt, dann hol die refernez zu dem script
        _outOfBoundsScript = GameObject.Find("Bounds").GetComponent<OutOfBounds>();
        
        // grundsätzlich muss ein game object erst bei start deaktiviert werden, damit es erkannt werden kann und du drauf zugreifen kannst
        // in dem fall habe ich das scipt auf das obere element "GameOverMenu" gelegt.
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // abfrage nach der gameisover variable, die im outofbounds script referenziert wird
        // bei boolean variablen reicht es GameIsOver (ist true), !GameIsOver (wäre false)
        if(_outOfBoundsScript.gameIsOver)
        {
            gameOverCanvas.SetActive(true);
            Debug.Log("Display GameOver Canvas");
            
            _outOfBoundsScript.gameIsOver = false;
        }
    }
}
