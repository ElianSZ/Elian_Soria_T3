using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // cuando un objeto que tiene trigger detecta otro objeto con trigger
    private void OnTriggerEnter(Collider otherTrigger)
    {
        Destroy(otherTrigger.gameObject);   // Se destruye el otro game object que tiene trigger (animal)
        Destroy(gameObject);                // Se destruye el game object que tiene trigger (pizza)
    }
}
