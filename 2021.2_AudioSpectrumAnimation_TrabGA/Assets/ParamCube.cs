using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int _band;
    public float _startScale, _scaleMultiplier;
    public bool _useBuffer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (SpectrumManager._audioBandBuffer[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
         //   transform.localScale = new Vector3(10, (SpectrumManager._audioBandBuffer[_band] * _scaleMultiplier) + _startScale, 10);
        }

        if (!_useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (SpectrumManager._audioBand[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
         //   transform.localScale = new Vector3(10, (SpectrumManager._audioBand[_band] * _scaleMultiplier) + _startScale, 10);
        }
    }
}
