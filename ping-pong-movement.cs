using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    [SerializeField] private float range;
    private float movementMultipler;
    private float previousMultipler;
    
    void Update()
    {
        movementMultipler = (range * Mathf.Sin((Time.realtimeSinceStartup % 4) * Mathf.PI / 2) / 2);
        transform.position += Vector3.up * movementMultipler - Vector3.up * previousMultipler;
        previousMultipler = movementMultipler;
    }
}
