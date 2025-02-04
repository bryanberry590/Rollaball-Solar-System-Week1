using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float rotateDegreesPerSecond = 45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = GetComponent<Transform>();
        myTransform.Rotate(new Vector3(rotateDegreesPerSecond, rotateDegreesPerSecond, rotateDegreesPerSecond) * Time.deltaTime);
    }
}
