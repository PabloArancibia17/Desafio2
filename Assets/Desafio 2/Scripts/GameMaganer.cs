using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaganer : MonoBehaviour
{
    public static bool gameOver = false;
    public GameObject controladorPelotas;
    public GameObject text;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            Debug.Log("Game Over");
            Destroy(controladorPelotas);
            text.SetActive(true);
            
        }
    }
}
