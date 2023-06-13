using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundInterval : MonoBehaviour
{
    public AudioSource source;
    public float minWaitBetweenPlays = 5f;
    public float maxWaitBetweenPlays = 10f;
    public float waitTimeCountdown = -1f;

    void Start()
    {
    }

    void Update()
    {
        if (!source.isPlaying)
        {
            if (waitTimeCountdown < 0f)
            {
                source.Play();
                waitTimeCountdown = Random.Range(minWaitBetweenPlays, maxWaitBetweenPlays);
            }
            else
            {
                waitTimeCountdown -= Time.deltaTime;
            }
        }
    }
}
