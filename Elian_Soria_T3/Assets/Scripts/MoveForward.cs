using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f;
    private float upperLim = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }
    }
}