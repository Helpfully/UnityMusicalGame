using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Song : MusicalScript
{
    public List<ChordStream> ChordStreams;
    public float Volume = 1.0f;
    public float PlaySpeed = 1.0f;
    public float PlaySpeedMultiplier
    {
        get
        {
            if (PlaySpeed < 0.01f)
            {
                return 1.0f;
            }
            return 1.0f / PlaySpeed;
        }
    }

    public Song()
    {
        ChordStreams = new List<ChordStream>();
    }
}
