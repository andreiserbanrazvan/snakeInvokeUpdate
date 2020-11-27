using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance;


    private float _amplitude = 0.1f;
    private float _duration = 0.5f;

    private Vector3 initialPosition;
    private bool isShaking = false;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        initialPosition = transform.localPosition;
    }

    public void Shake(float amplitude, float duration)
    {
        _amplitude = amplitude;
        isShaking = true;
        CancelInvoke();
        Invoke("StopShaking", duration);
    }

    public void StopShaking()
    {
       
        isShaking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isShaking)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * _amplitude;
        }
       
    }
}
