using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToSpawnTransform : MonoBehaviour
{ public Transform transformToreset;

    public Vector3 StartLocation;

        public Vector3 StartRotation;
    // Start is called before the first frame update
    void Start()
    {
        StartLocation = transformToreset.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
