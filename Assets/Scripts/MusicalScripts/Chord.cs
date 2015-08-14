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
    private float length = 1.0f;
    public NoteLength Length;

    public float Time
    {
        get
        {
            if (Length == NoteLength.Specific)
            {
                return length;
            }
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
            note.Length = length;
            note.ParentChord = this;
            note.Tone = (Tones)item;

            Notes.Add(note);
        }
        Length = length;
        ParentChordStream = parentStream;
        parentStream.chords.Add(this);
    }

    public Chord(ChordStream parentStream, int length, params int[] notes)
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
            note.Length = (NoteLength)length;
            note.ParentChord = this;
            note.Tone = (Tones)item;

            Notes.Add(note);
        }
        Length = (NoteLength)length;
        ParentChordStream = parentStream;
        parentStream.chords.Add(this);
    }

    public Chord(ChordStream parentStream, float specificLength, params int[] notes)
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
            note.Length = NoteLength.Specific;
            note.ParentChord = this;
            note.Tone = (Tones)item;

            Notes.Add(note);
        }
        length = specificLength;
        ParentChordStream = parentStream;
        parentStream.chords.Add(this);
    }
}
