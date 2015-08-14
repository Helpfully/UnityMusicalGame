﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Song : MusicalScript
{
    public List<ChordStream> ChordStreams;
    public float Volume = 1.0f;

    public Song()
    {
        ChordStreams = new List<ChordStream>();
    }
}
