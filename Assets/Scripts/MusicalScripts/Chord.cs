using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chord : MusicalScript
{
    public List<Note> notes;
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

    public float Time
    {
        get
        {
            return (int)Length / 16;
        }
    }

    public Chord()
    {
        notes = new List<Note>();
    }
}
