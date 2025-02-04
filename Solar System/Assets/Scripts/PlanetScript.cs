using UnityEngine;

public class PlanetScript : MonoBehaviour
{

    public GameObject sun;
    public float yawDPS = 45f;
    public float orbitRotationDPS = 45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = GetComponent<Transform>();
        myTransform.Rotate(0f, yawDPS * Time.deltaTime, 0f);
        myTransform.RotateAround(sun.transform.position, Vector3.up, orbitRotationDPS * Time.deltaTime);
    }
}
