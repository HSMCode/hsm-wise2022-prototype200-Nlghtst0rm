using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleted : MonoBehaviour
{
    // variable für das gameobject, wo das script drauf liegt
    public GameObject LevelCompleteCanvas;
    
    // variable für das script, welches geholt werden soll
    private GoalCollider _GoalColliderScript;

    // Start is called before the first frame update
    void Start()
    { 
        // Variable mit der script referenz befüllen.
        // suche nach dem game object wo das script drauf liegt, dann hol die refernez zu dem script
        _GoalColliderScript = GameObject.Find("GoalTrigger").GetComponent<GoalCollider>();
        
        // grundsätzlich muss ein game object erst bei start deaktiviert werden, damit es erkannt werden kann und du drauf zugreifen kannst
        // in dem fall habe ich das scipt auf das obere element "GameOverMenu" gelegt.
        LevelCompleteCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // abfrage nach der gameisover variable, die im outofbounds script referenziert wird
        // bei boolean variablen reicht es GameIsOver (ist true), !GameIsOver (wäre false)
        if(_GoalColliderScript.YouWon)
        {
            LevelCompleteCanvas.SetActive(true);
            Debug.Log("Display LevelCompleted Canvas");
            
            _GoalColliderScript.YouWon = false;
        }
    }
}


