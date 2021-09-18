using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target;
    public float radius;
    public float speed;
    public Vector3 offset;

    void FixedUpdate () 
    {
        Vector3 relativePos = target.position - transform.position + offset;
        
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        Quaternion current = transform.localRotation;
        
        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime * speed);
        transform.Translate(0, 0, radius * Mathf.PI * speed * Time.deltaTime / 2f);
    }
}
