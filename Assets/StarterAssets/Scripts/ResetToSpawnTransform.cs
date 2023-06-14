using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToSpawnTransform : MonoBehaviour
{
    public Transform transformToreset;

    public Vector3 StartLocation;

    public Vector3 StartRotationAngles;

    public Quaternion StartRotation;
    // Start is called before the first frame update
    void Start()
    {
        if (transformToreset== null)
        {

            transformToreset = transform;

        }



        StartLocation = transformToreset.position;
        StartRotation = transformToreset.rotation;
        StartRotationAngles = StartRotation.eulerAngles;  
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("2137");
            transformToreset.position = StartLocation;
            StartRotation.eulerAngles = StartRotationAngles;
            transformToreset.rotation = StartRotation;
        }
    }

}