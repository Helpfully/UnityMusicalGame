using UnityEngine;
using System.Collections;

public class SoundPoolController : MusicalScript
{
    const int NUMBER_OF_NOTES = 49;

    

    private bool isNotesSetUp = false;
    MusicalSound[] musicalSoundsArray;
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
        musicalSoundsArray = new MusicalSound[NUMBER_OF_NOTES];

        musicalSoundsArray[0]  = transform.FindChild("DO1").GetComponent<MusicalSound>();
        musicalSoundsArray[1]  = transform.FindChild("DOS1").GetComponent<MusicalSound>();
        musicalSoundsArray[2]  = transform.FindChild("RE1").GetComponent<MusicalSound>();
        musicalSoundsArray[3]  = transform.FindChild("RES1").GetComponent<MusicalSound>();
        musicalSoundsArray[4]  = transform.FindChild("MI1").GetComponent<MusicalSound>();
        musicalSoundsArray[5]  = transform.FindChild("FA1").GetComponent<MusicalSound>();
        musicalSoundsArray[6]  = transform.FindChild("FAS1").GetComponent<MusicalSound>();
        musicalSoundsArray[7]  = transform.FindChild("SO1").GetComponent<MusicalSound>();
        musicalSoundsArray[8]  = transform.FindChild("SOS1").GetComponent<MusicalSound>();
        musicalSoundsArray[9]  = transform.FindChild("LA1").GetComponent<MusicalSound>();
        musicalSoundsArray[10] = transform.FindChild("LAS1").GetComponent<MusicalSound>();
        musicalSoundsArray[11] = transform.FindChild("SI1").GetComponent<MusicalSound>();
        musicalSoundsArray[12] = transform.FindChild("DO2").GetComponent<MusicalSound>();
        musicalSoundsArray[13] = transform.FindChild("DOS2").GetComponent<MusicalSound>();
        musicalSoundsArray[14] = transform.FindChild("RE2").GetComponent<MusicalSound>();
        musicalSoundsArray[15] = transform.FindChild("RES2").GetComponent<MusicalSound>();
        musicalSoundsArray[16] = transform.FindChild("MI2").GetComponent<MusicalSound>();
        musicalSoundsArray[17] = transform.FindChild("FA2").GetComponent<MusicalSound>();
        musicalSoundsArray[18] = transform.FindChild("FAS2").GetComponent<MusicalSound>();
        musicalSoundsArray[19] = transform.FindChild("SO2").GetComponent<MusicalSound>();
        musicalSoundsArray[20] = transform.FindChild("SOS2").GetComponent<MusicalSound>();
        musicalSoundsArray[21] = transform.FindChild("LA2").GetComponent<MusicalSound>();
        musicalSoundsArray[22] = transform.FindChild("LAS2").GetComponent<MusicalSound>();
        musicalSoundsArray[23] = transform.FindChild("SI2").GetComponent<MusicalSound>();
        musicalSoundsArray[24] = transform.FindChild("DO3").GetComponent<MusicalSound>();
        musicalSoundsArray[25] = transform.FindChild("DOS3").GetComponent<MusicalSound>();
        musicalSoundsArray[26] = transform.FindChild("RE3").GetComponent<MusicalSound>();
        musicalSoundsArray[27] = transform.FindChild("RES3").GetComponent<MusicalSound>();
        musicalSoundsArray[28] = transform.FindChild("MI3").GetComponent<MusicalSound>();
        musicalSoundsArray[29] = transform.FindChild("FA3").GetComponent<MusicalSound>();
        musicalSoundsArray[30] = transform.FindChild("FAS3").GetComponent<MusicalSound>();
        musicalSoundsArray[31] = transform.FindChild("SO3").GetComponent<MusicalSound>();
        musicalSoundsArray[32] = transform.FindChild("SOS3").GetComponent<MusicalSound>();
        musicalSoundsArray[33] = transform.FindChild("LA3").GetComponent<MusicalSound>();
        musicalSoundsArray[34] = transform.FindChild("LAS3").GetComponent<MusicalSound>();
        musicalSoundsArray[35] = transform.FindChild("SI3").GetComponent<MusicalSound>();
        musicalSoundsArray[36] = transform.FindChild("DO4").GetComponent<MusicalSound>();
        musicalSoundsArray[37] = transform.FindChild("DOS4").GetComponent<MusicalSound>();
        musicalSoundsArray[38] = transform.FindChild("RE4").GetComponent<MusicalSound>();
        musicalSoundsArray[39] = transform.FindChild("RES4").GetComponent<MusicalSound>();
        musicalSoundsArray[40] = transform.FindChild("MI4").GetComponent<MusicalSound>();
        musicalSoundsArray[41] = transform.FindChild("FA4").GetComponent<MusicalSound>();
        musicalSoundsArray[42] = transform.FindChild("FAS4").GetComponent<MusicalSound>();
        musicalSoundsArray[43] = transform.FindChild("SO4").GetComponent<MusicalSound>();
        musicalSoundsArray[44] = transform.FindChild("SOS4").GetComponent<MusicalSound>();
        musicalSoundsArray[45] = transform.FindChild("LA4").GetComponent<MusicalSound>();
        musicalSoundsArray[46] = transform.FindChild("LAS4").GetComponent<MusicalSound>();
        musicalSoundsArray[47] = transform.FindChild("SI4").GetComponent<MusicalSound>();
        musicalSoundsArray[48] = transform.FindChild("DO5").GetComponent<MusicalSound>();
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
        MusicalSound note = musicalSoundsArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote();
    }

    public void PlayNote(int pNote, float pVolume)
    {
        MusicalSound note = musicalSoundsArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote(pVolume, 0);
    }

    public void PlayNote(int pNote, float pVolume, float time, bool useTime = false)
    {
        MusicalSound note = musicalSoundsArray[pNote % NUMBER_OF_NOTES];
        note.PlayNote(pVolume, time, useTime);
    }
}
