using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaayCookingSounds : MonoBehaviour
{
    public AudioSource Source;
    public bool PlaySound = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlaySound)
        {
            Debug.Log(Source.isPlaying);
            if(!Source.isPlaying)
            {
                Source.Play();
            }
        }
        if(!PlaySound && Source.isPlaying) 
        {
            Source.Stop();
        }
    }
}
