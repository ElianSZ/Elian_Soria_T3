using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10f;
    private float horizontalInput;
    float xRange = 16f;

    public GameObject projectilPrefab;
    // projectilPrefab = el proyectil que queremos usar, en el editor le damos al Player y en la variable projectilPrefab le añadimos nuesro proyectil (pizza)

    // Start is called before the first frame update
    void Start()
    {
        //Posición inicial del Player = (0,0,0)
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // Time.deltaTime = aceleración

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Se dispara una pizza
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);

            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.rotation);
        }
    }
}
