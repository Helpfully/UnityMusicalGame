using UnityEngine;
using System.Collections;

public class Song : MusicalScript
{
    public Note[] Notes;

    // Use this for initialization
    void Start()
    {
        MarioNotes = new Note[] 
        {
            new Note() {}
        };
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Note[] MarioNotes;
}
