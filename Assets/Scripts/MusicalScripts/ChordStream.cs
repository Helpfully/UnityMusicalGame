using UnityEngine;
using System.Collections;

public class ChordStream : MusicalScript
{
    public Chord[] chords;
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
        
    }
}
