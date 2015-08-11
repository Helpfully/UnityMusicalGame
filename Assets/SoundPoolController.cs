using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundPoolController : MonoBehaviour
{
    const int NUMBER_OF_NOTES = 49;

    private bool isNotesSetUp = false;
    MusicalSound[] notesArray;
    private static SoundPoolController sPrivateInstance;
    public static SoundPoolController sInstance
    {
        get
        {
            if (sPrivateInstance == null)
            {
                sfCreatePool();
            }
            return sPrivateInstance;
        }
    }

    private static void sfCreatePool()
    {
        GameObject lPool = GameObject.Instantiate(Resources.Load("Prefab/SystemPool/SoundPool") as GameObject) as GameObject;
        sPrivateInstance = lPool.GetComponent<SoundPoolController>();
        if (!sPrivateInstance.isNotesSetUp) sPrivateInstance.fSetupNotes();
    }

    private void fSetupNotes()
    {
        isNotesSetUp = true;
        notesArray = new MusicalSound[NUMBER_OF_NOTES];

        notesArray[0]  = transform.FindChild("DO1").GetComponent<MusicalSound>();
        notesArray[1]  = transform.FindChild("DOS1").GetComponent<MusicalSound>();
        notesArray[2]  = transform.FindChild("RE1").GetComponent<MusicalSound>();
        notesArray[3]  = transform.FindChild("RES1").GetComponent<MusicalSound>();
        notesArray[4]  = transform.FindChild("MI1").GetComponent<MusicalSound>();
        notesArray[5]  = transform.FindChild("FA1").GetComponent<MusicalSound>();
        notesArray[6]  = transform.FindChild("FAS1").GetComponent<MusicalSound>();
        notesArray[7]  = transform.FindChild("SO1").GetComponent<MusicalSound>();
        notesArray[8]  = transform.FindChild("SOS1").GetComponent<MusicalSound>();
        notesArray[9]  = transform.FindChild("LA1").GetComponent<MusicalSound>();
        notesArray[10] = transform.FindChild("LAS1").GetComponent<MusicalSound>();
        notesArray[11] = transform.FindChild("SI1").GetComponent<MusicalSound>();
        notesArray[12] = transform.FindChild("DO2").GetComponent<MusicalSound>();
        notesArray[13] = transform.FindChild("DOS2").GetComponent<MusicalSound>();
        notesArray[14] = transform.FindChild("RE2").GetComponent<MusicalSound>();
        notesArray[15] = transform.FindChild("RES2").GetComponent<MusicalSound>();
        notesArray[16] = transform.FindChild("MI2").GetComponent<MusicalSound>();
        notesArray[17] = transform.FindChild("FA2").GetComponent<MusicalSound>();
        notesArray[18] = transform.FindChild("FAS2").GetComponent<MusicalSound>();
        notesArray[19] = transform.FindChild("SO2").GetComponent<MusicalSound>();
        notesArray[20] = transform.FindChild("SOS2").GetComponent<MusicalSound>();
        notesArray[21] = transform.FindChild("LA2").GetComponent<MusicalSound>();
        notesArray[22] = transform.FindChild("LAS2").GetComponent<MusicalSound>();
        notesArray[23] = transform.FindChild("SI2").GetComponent<MusicalSound>();
        notesArray[24] = transform.FindChild("DO3").GetComponent<MusicalSound>();
        notesArray[25] = transform.FindChild("DOS3").GetComponent<MusicalSound>();
        notesArray[26] = transform.FindChild("RE3").GetComponent<MusicalSound>();
        notesArray[27] = transform.FindChild("RES3").GetComponent<MusicalSound>();
        notesArray[28] = transform.FindChild("MI3").GetComponent<MusicalSound>();
        notesArray[29] = transform.FindChild("FA3").GetComponent<MusicalSound>();
        notesArray[30] = transform.FindChild("FAS3").GetComponent<MusicalSound>();
        notesArray[31] = transform.FindChild("SO3").GetComponent<MusicalSound>();
        notesArray[32] = transform.FindChild("SOS3").GetComponent<MusicalSound>();
        notesArray[33] = transform.FindChild("LA3").GetComponent<MusicalSound>();
        notesArray[34] = transform.FindChild("LAS3").GetComponent<MusicalSound>();
        notesArray[35] = transform.FindChild("SI3").GetComponent<MusicalSound>();
        notesArray[36] = transform.FindChild("DO4").GetComponent<MusicalSound>();
        notesArray[37] = transform.FindChild("DOS4").GetComponent<MusicalSound>();
        notesArray[38] = transform.FindChild("RE4").GetComponent<MusicalSound>();
        notesArray[39] = transform.FindChild("RES4").GetComponent<MusicalSound>();
        notesArray[40] = transform.FindChild("MI4").GetComponent<MusicalSound>();
        notesArray[41] = transform.FindChild("FA4").GetComponent<MusicalSound>();
        notesArray[42] = transform.FindChild("FAS4").GetComponent<MusicalSound>();
        notesArray[43] = transform.FindChild("SO4").GetComponent<MusicalSound>();
        notesArray[44] = transform.FindChild("SOS4").GetComponent<MusicalSound>();
        notesArray[45] = transform.FindChild("LA4").GetComponent<MusicalSound>();
        notesArray[46] = transform.FindChild("LAS4").GetComponent<MusicalSound>();
        notesArray[47] = transform.FindChild("SI4").GetComponent<MusicalSound>();
        notesArray[48] = transform.FindChild("DO5").GetComponent<MusicalSound>();
    }

    void Awake()
    {
        sPrivateInstance = this;
        if (!isNotesSetUp) fSetupNotes();
    }

    // Use this for initialization
    void Start()
    {
        var mario = MusicalScript.GetMarioTheme();
        PlaySong(mario);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayNote((int)Tones.DO1, 1f, 0.25f, true);
        }
        HandleSongs();
    }

    private void HandleSongs()
    {
        for (int i = 0; i < StreamsPlaying.Count; i++)
        {
            Debug.Log(StreamsPlaying);
            var stream = StreamsPlaying[i];
            stream.StreamTimer += Time.deltaTime;
            if (stream.CheckIfNextChordReady())
            {
                PlayNextChord(stream);
            }
        }

        for (int i = StreamsPlaying.Count - 1; i >= 0; i--)
        {
            var stream = StreamsPlaying[i];
            if (stream.IsEndOfSong)
            {
                StreamsPlaying.Remove(stream);
            }
        }
    }

    public void PlayNote(int pNote)
    {
        MusicalSound note = notesArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote();
    }

    public void PlayNote(int pNote, float pVolume)
    {
        MusicalSound note = notesArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote(pVolume, 0);
    }

    public void PlayNote(int pNote, float pVolume, float time, bool useTime = false)
    {
        MusicalSound note = notesArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote(pVolume, time, useTime);
    }

    public List<Song> SongsPlaying = new List<Song>();
    public List<ChordStream> StreamsPlaying = new List<ChordStream>();
    public List<float> StreamTimers = new List<float>();


    public void PlaySong(Song song)
    {
        foreach (var item in song.ChordStreams)
        {
            StreamsPlaying.Add(item);
        }
    }

    public void PlayStream(ChordStream stream)
    {

    }

    public void PlayNextChord(ChordStream stream)
    {
        Chord currentChord = stream.CurrentChord;

        if (!currentChord.isSilence)
	    {
	    	foreach (var item in currentChord.Notes)
            {
                PlayNote(item.NoteCode, item.Volume, item.Time, true);
            } 
	    }
    }
}
