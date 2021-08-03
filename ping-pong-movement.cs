using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    public float range;
    public float pingPongMath;
    private float _lastYPos;

    void Update()
    {
        pingPongMath = range * Mathf.Sin((Time.realtimeSinceStartup % 4) * Mathf.PI / 2) / 2;
        transform.position += Vector3.up * pingPongMath - Vector3.up * _lastYPos;
        _lastYPos = pingPongMath;
    }
}
