using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target;
    public float radius;
    public float height;

    void Update () 
    {
        Vector3 relativePos = (target.position + new Vector3(0, height, 0)) - transform.position;
        
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        
        transform.Translate(0, 0, radius * (3f/2) * Time.deltaTime);
    }
}
