using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ControladorCreacionPelotas : MonoBehaviour
{
    public GameObject[] prefabsPelotas;

    private float limiteXSpawnIzquierdo = -22;
    private float limiteXSpawnDerecho = 7;
    private float posicionYSpawn = 30;

    private float delayStart = 1.0f;
    private float intervaloSpawn = 4.0f;

    // Start es llamado antes que el primer cuadro sea actualizado
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", delayStart, intervaloSpawn);
    }

    // Crea una pelota con una posicion x aleatoria al tope del area de juego
    void SpawnRandomBall ()
    {
        // Instanciar la pelota en un lugar aleatorio        
        Vector3 spawnPos = new Vector3(Random.Range(limiteXSpawnIzquierdo, limiteXSpawnDerecho), posicionYSpawn, 0);

        // Generar indice aleatorio de la pelota y posicion aleatoria
        Instantiate(prefabsPelotas[Random.Range(0,3)], spawnPos, transform.rotation);

    }

}
