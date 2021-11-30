using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBond : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -5f;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Proyectil supera el límite superior de la pantalla
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }

        // Animal supera el límite inferior de la pantalla
        if (transform.position.z < lowerLim)
        {
            player = GameObject.Find("Player");
            Destroy(player);                            // player = GameObject("Player")
            Destroy(gameObject);
            Debug.Log(message: "GAME OVER");
            Time.timeScale = 0;                         // Paro todo el juego
        }
    }
}
