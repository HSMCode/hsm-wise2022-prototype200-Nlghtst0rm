using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject GameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {   
    OutOfBounds refScript = GetComponent<OutOfBounds>();
    }

    // Update is called once per frame
    void Update()
    {
        if(OutOfBounds.GameIsOver == true)
        {
            Debug.Log("GameOver");
            GameOverCanvas.SetActive(true);
        }
    }

}
