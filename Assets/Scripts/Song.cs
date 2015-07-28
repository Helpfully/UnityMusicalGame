using UnityEngine;
using System.Collections;

public class Song : MusicalScript
{
    public MusicalSound[] Notes;

    // Use this for initialization
    void Start()
    {
        MarioNotes = new MusicalSound[] 
        {
            
        };
    }

    // Update is called once per frame
    void Update()
    {

    }

    private MusicalSound[] MarioNotes;
}
