using UnityEngine;

public class PingPongOscillation : MonoBehaviour
{
    [SerializeField] [Range(0,2)] private float range;
    [SerializeField] [Range(0,4)] private float offset;
    [SerializeField] private Vector3 direction;
    
    void Update()
    {
        transform.position += Oscillation(range, direction, offset);
    }
    
    public static Vector3 Oscillation(float oscillationRange, Vector3 oscillationDirection, float oscillationTimeOffset = 0)
    {
        float oscillation = oscillationRange * Mathf.Sin(((Time.realtimeSinceStartup + oscillationTimeOffset)% 4) * Mathf.PI / 2);
        return oscillationDirection * (oscillation * Time.deltaTime);
    }
}
