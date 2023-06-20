using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualVignetteEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var renderer = GetComponent<Renderer>();

        var mainMaterial = renderer.material;

        mainMaterial.SetFloat("_ApertureSize", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}