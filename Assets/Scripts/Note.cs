using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Note : MusicalScript
{
    AudioSource note
    {
        get
        {
            return GetComponent<AudioSource>();
        }
    }

    public float SmoothStopThreshold = 0.1f;
    public float SmoothStopSpeed = 1.0f;
    private bool SmoothStopActive = false;

    public float SmoothPlayThreshold = 0.9f;
    public float SmoothPlaySpeed = 1.0f;
    private bool SmoothPlayActive = false;

    private float DesiredVolume = 1.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SmoothStopActive)
        {
            note.volume = Mathf.Lerp(note.volume, 0.0f, Time.deltaTime * SmoothStopSpeed);
            if (note.volume < SmoothStopThreshold)
            {
                SmoothStopActive = false;
                note.volume = 0;
            }
        }
        else if (SmoothPlayActive)
        {
            note.volume = Mathf.Lerp(note.volume, DesiredVolume, Time.deltaTime * SmoothStopSpeed);
            if (note.volume < DesiredVolume - (1.0f - SmoothStopThreshold))
            {
                SmoothPlayActive = false;
                note.volume = DesiredVolume;
            }
        }
    }

    public void PlayNote()
    {
        PlayNote(1, 0);
    }

    public void PlayNote(float time)
    {
        PlayNote(1, time, true);
    }

    public void PlayNote(float volume, float time, bool useTime = false)
    {
        CancelInvoke("SmoothStopNote");
        SmoothStopActive = false;
        note.volume = volume;
        DesiredVolume = volume;
        if (note.isPlaying)
        {
            note.timeSamples = 0;
        }
        else
        {
            note.Play();
        }
        if (useTime) Invoke("SmoothStopNote", time);
    }

    private void StopNote()
    {
        note.Stop();
    }

    private void SmoothStopNote()
    {
        SmoothStopActive = true;
    }

    private void SmoothPlayNote()
    {
        note.volume = 0;
        SmoothPlayActive = true;
        if (note.isPlaying)
        {
            note.timeSamples = 0;
        }
        else
        {
            note.Play();
        }
    }
}
