using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ControladorDeJugador : MonoBehaviour
{
    public GameObject prefabPerro;
    public float time = 2;
    public float spawnTime = 1.5f;

    
    
    // Update es llamado una vez por cuadro
    void Update()
    {
        // Instanciar perro cuando se presiona la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space) && time > spawnTime)
        {
            Instantiate(prefabPerro, transform.position, prefabPerro.transform.rotation);
            time = 0;
            
            
            
        }

        time += Time.deltaTime;


    }

    
}
