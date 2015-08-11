using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Chord : MusicalScript
{
    public List<Note> Notes;
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
            return (int)Length / 16f;
        }
    }

    public Chord()
    {
        Notes = new List<Note>();
    }

    public Chord(ChordStream parentStream, NoteLength length, params int[] notes)
    {
        Notes = new List<Note>();

        foreach (var item in notes)
        {
            if (item == -1)
            {
                isSilence = true;
                break;
            }
            var note = new Note();
            note.NoteLength = length;
            note.ParentChord = this;
            note.Tone = (Tones)item;

            Notes.Add(note);
        }
        Length = length;
        ParentChordStream = parentStream;
        parentStream.chords.Add(this);
    }
}
