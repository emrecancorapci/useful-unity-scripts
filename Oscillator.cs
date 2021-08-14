using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] [Range(0,2)] private float range;
    [SerializeField] [Range(0,4)] private float offset;
    private float lastOscillation;

    void Update()
    {
        transform.position += Oscillation(range, Vector3.up, offset);
    }
    public Vector3 Oscillation(float oscillationRange, Vector3 oscillationDirection, float oscillationTimeOffset = 0)
    {
        float oscillation = oscillationRange * Mathf.Sin((Time.time + oscillationTimeOffset)% 4 * Mathf.PI * 0.5f) * 0.5f;
        Vector3 oscillator = oscillationDirection * (oscillation - lastOscillation);
        lastOscillation = oscillation;
        return oscillator;
    }
}
