using UnityEngine;
using System.Collections;

public class Note : MusicalScript
{
    public Tones Tone;
    public NoteLength Length = NoteLength.Quarter;
    private float volume;

    public float Volume
    {
        get 
        {
            if (ParentChord != null)
            {
                return ParentChord.Volume;
            }
            return volume; 
        }
        set 
        {
            volume = value; 
        }
    }

    public Chord ParentChord;

    private float length = 1.0f;
    public float Time
    {
        get
        {
            if (Length == NoteLength.Specific)
            {
                return length;
            }
            return (int)Length / 16;
        }
    }

    public int NoteCode
    {
        get
        {
            return (int)Tone;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        SoundPool.PlayNote((int)Tone, Volume, Time, true);
    }
}
