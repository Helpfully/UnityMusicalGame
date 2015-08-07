﻿using UnityEngine;
using System.Collections;

public class Chord : MusicalScript
{
    public Note[] notes;
    public bool isSilence = false;
    private float volume = 1.0f;
    public float Volume
    {
        get
        {
            if (ParentChordStream != null)
            {
                return ParentChordStream.Volume;
            }
            else
            {
                return volume;
            }
        }
    }

    public ChordStream ParentChordStream;
    public NoteLength Length;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
