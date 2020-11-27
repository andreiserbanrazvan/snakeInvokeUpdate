using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeOnStart : MonoBehaviour
{
    public float amplitude = 0.1f;
    public float duration = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        CameraShake.Instance.Shake(amplitude, duration); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
