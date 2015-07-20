using UnityEngine;
using System.Collections;

public class SoundPoolController : MusicalScript
{
    const int NUMBER_OF_NOTES = 49;

    

    private bool isNotesSetUp = false;
    Note[] notesArray;
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
        notesArray = new Note[NUMBER_OF_NOTES];

        notesArray[0]  = transform.FindChild("DO1").GetComponent<Note>();
        notesArray[1]  = transform.FindChild("DOS1").GetComponent<Note>();
        notesArray[2]  = transform.FindChild("RE1").GetComponent<Note>();
        notesArray[3]  = transform.FindChild("RES1").GetComponent<Note>();
        notesArray[4]  = transform.FindChild("MI1").GetComponent<Note>();
        notesArray[5]  = transform.FindChild("FA1").GetComponent<Note>();
        notesArray[6]  = transform.FindChild("FAS1").GetComponent<Note>();
        notesArray[7]  = transform.FindChild("SO1").GetComponent<Note>();
        notesArray[8]  = transform.FindChild("SOS1").GetComponent<Note>();
        notesArray[9]  = transform.FindChild("LA1").GetComponent<Note>();
        notesArray[10] = transform.FindChild("LAS1").GetComponent<Note>();
        notesArray[11] = transform.FindChild("SI1").GetComponent<Note>();
        notesArray[12] = transform.FindChild("DO2").GetComponent<Note>();
        notesArray[13] = transform.FindChild("DOS2").GetComponent<Note>();
        notesArray[14] = transform.FindChild("RE2").GetComponent<Note>();
        notesArray[15] = transform.FindChild("RES2").GetComponent<Note>();
        notesArray[16] = transform.FindChild("MI2").GetComponent<Note>();
        notesArray[17] = transform.FindChild("FA2").GetComponent<Note>();
        notesArray[18] = transform.FindChild("FAS2").GetComponent<Note>();
        notesArray[19] = transform.FindChild("SO2").GetComponent<Note>();
        notesArray[20] = transform.FindChild("SOS2").GetComponent<Note>();
        notesArray[21] = transform.FindChild("LA2").GetComponent<Note>();
        notesArray[22] = transform.FindChild("LAS2").GetComponent<Note>();
        notesArray[23] = transform.FindChild("SI2").GetComponent<Note>();
        notesArray[24] = transform.FindChild("DO3").GetComponent<Note>();
        notesArray[25] = transform.FindChild("DOS3").GetComponent<Note>();
        notesArray[26] = transform.FindChild("RE3").GetComponent<Note>();
        notesArray[27] = transform.FindChild("RES3").GetComponent<Note>();
        notesArray[28] = transform.FindChild("MI3").GetComponent<Note>();
        notesArray[29] = transform.FindChild("FA3").GetComponent<Note>();
        notesArray[30] = transform.FindChild("FAS3").GetComponent<Note>();
        notesArray[31] = transform.FindChild("SO3").GetComponent<Note>();
        notesArray[32] = transform.FindChild("SOS3").GetComponent<Note>();
        notesArray[33] = transform.FindChild("LA3").GetComponent<Note>();
        notesArray[34] = transform.FindChild("LAS3").GetComponent<Note>();
        notesArray[35] = transform.FindChild("SI3").GetComponent<Note>();
        notesArray[36] = transform.FindChild("DO4").GetComponent<Note>();
        notesArray[37] = transform.FindChild("DOS4").GetComponent<Note>();
        notesArray[38] = transform.FindChild("RE4").GetComponent<Note>();
        notesArray[39] = transform.FindChild("RES4").GetComponent<Note>();
        notesArray[40] = transform.FindChild("MI4").GetComponent<Note>();
        notesArray[41] = transform.FindChild("FA4").GetComponent<Note>();
        notesArray[42] = transform.FindChild("FAS4").GetComponent<Note>();
        notesArray[43] = transform.FindChild("SO4").GetComponent<Note>();
        notesArray[44] = transform.FindChild("SOS4").GetComponent<Note>();
        notesArray[45] = transform.FindChild("LA4").GetComponent<Note>();
        notesArray[46] = transform.FindChild("LAS4").GetComponent<Note>();
        notesArray[47] = transform.FindChild("SI4").GetComponent<Note>();
        notesArray[48] = transform.FindChild("DO5").GetComponent<Note>();
    }

    void Awake()
    {
        sPrivateInstance = this;
        if (!isNotesSetUp) fSetupNotes();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayNote(DO1, 1f, 0.25f, true);
        }
    }

    public void PlayNote(int pNote)
    {
        Note note = notesArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote();
    }

    public void PlayNote(int pNote, float pVolume)
    {
        Note note = notesArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote(pVolume, 0);
    }

    public void PlayNote(int pNote, float pVolume, float time, bool useTime = false)
    {
        Note note = notesArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote(pVolume, time, useTime);
    }
}
