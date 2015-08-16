using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChordStream : MusicalScript
{
    public List<Chord> chords;
    public Song ParentSong;
    private float volume = 1.0f;
    public float Volume
    {
        get
        {
            if (ParentSong != null)
            {
                return ParentSong.Volume;
            }
            else
            {
                return volume;
            }
        }
    }

    private float playSpeed = 1.0f;

    public float PlaySpeedMultiplier
    {
        get
        {
            if (ParentSong != null)
            {
                return ParentSong.PlaySpeedMultiplier;
            }
            else
            {
                if (playSpeed < 0.01f)
                {
                    return 1.0f;
                }
                return 1.0f / playSpeed;
            }
        }
    }

    public int StreamIndex = 0;
    public float StreamTimer = 0.0f;

    public bool IsEndOfSong = false;
    // Use this for initialization
    public bool InitialPlay = true;

    public Chord CurrentChord
    {
        get
        {
            return chords[StreamIndex];
        }
    }

    public ChordStream()
    {
        chords = new List<Chord>();
    }

    public bool CheckIfNextChordReady()
    {
        if (StreamIndex >= chords.Count - 1)
        {
            StreamIndex = 0;
            IsEndOfSong = true;
            StreamTimer = 0.0f;
            return false;
        }

        if (InitialPlay)
        {
            InitialPlay = false;
            StreamTimer = 0.0f;
            return true;
        }

        var currentChord = chords[StreamIndex];

        var currentChordTime = currentChord.Time;

        if (StreamTimer >= currentChordTime / PlaySpeedMultiplier)
        {
            //Debug.Log(StreamTimer);
            StreamTimer -= currentChordTime / PlaySpeedMultiplier;
            //Debug.LogWarning(StreamTimer);
            StreamIndex++;
            return true;
        }

        return false;
    }
}
