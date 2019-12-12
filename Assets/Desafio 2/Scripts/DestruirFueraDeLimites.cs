using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirFueraDeLimites : MonoBehaviour
{
    private float limiteIzquierdo = -50;
    public float limiteInferior = -5;
    

    // Update es llamado una vez por cuadro
    void Update()
    {
        // Destruimos los perros si la posicion x es menor que limiteIzquierdo
        if (transform.position.x <= limiteIzquierdo)
        {
            Destroy(gameObject);
        } 
        // Destruimos pelotas si la posicion y es menor al limiteInferior
        else if (transform.position.y < limiteInferior)
        {
            Destroy(gameObject);
            GameMaganer.gameOver = true;
        }
    }
}
