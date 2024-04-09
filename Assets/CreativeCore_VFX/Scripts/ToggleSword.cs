using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]

public class ToggleSword : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

    public ParticleSystem effect;

    bool isPlaying = true;

    private void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (isPlaying)
            {
                effect.Stop();
                isPlaying = false;
            }
            else
            {
                effect.Play();
                isPlaying = true;
            }
        }
    }
}
