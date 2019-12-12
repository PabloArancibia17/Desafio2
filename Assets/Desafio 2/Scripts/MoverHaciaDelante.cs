using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MoverHaciaDelante : MonoBehaviour
{
    public float velocidad;

    // Update es llamado una vez por cuadro
    void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}
