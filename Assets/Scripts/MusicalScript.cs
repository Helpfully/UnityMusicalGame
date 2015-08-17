using UnityEngine;
using System.Collections;

public class MusicalScript {

    #region Note Constants
    protected const int Silence = -1, DO1 = 0, DO2 = 12, DO3 = 24, DO4 = 36, DO5 = 48,
              DOS1 = 1, DOS2 = 13, DOS3 = 25, DOS4 = 37,
               RE1 = 2, RE2 = 14, RE3 = 26, RE4 = 38,
              RES1 = 3, RES2 = 15, RES3 = 27, RES4 = 39,
               MI1 = 4, MI2 = 16, MI3 = 28, MI4 = 40,
               FA1 = 5, FA2 = 17, FA3 = 29, FA4 = 41,
              FAS1 = 6, FAS2 = 18, FAS3 = 30, FAS4 = 42,
               SO1 = 7, SO2 = 19, SO3 = 31, SO4 = 43,
              SOS1 = 8, SOS2 = 20, SOS3 = 32, SOS4 = 44,
               LA1 = 9, LA2 = 21, LA3 = 33, LA4 = 45,
              LAS1 = 10, LAS2 = 22, LAS3 = 34, LAS4 = 46,
               SI1 = 11, SI2 = 23, SI3 = 35, SI4 = 47;

    protected const int SPS = -1, N64 = 1, N32 = 2, N16 = 4, N8 = 8, N4 = 16, N2 = 32, N1 = 64;
    #endregion

    protected SoundPoolController SoundPool { get { return SoundPoolController.sInstance; } }

    
    public static Song GetMarioTheme()
    {
        var song = new Song();
        song.PlaySpeed = 0.5f;

        var stream1 = new ChordStream();

        #region Right Hand

        #region Page 1

        //#region Section 1
        //new Chord(stream1, N16, MI4); 
        //new Chord(stream1, N8, MI4); 
        //new Chord(stream1, N16, MI4); 
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N8, MI4);
        //new Chord(stream1, N4, SO4).SetStaccato(true);
        //new Chord(stream1, N4, SO2).SetStaccato(true);
        //#endregion
        
        //#region Section 2
        //new Chord(stream1, N8, DO4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, SO3);
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N8, MI3);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, SI3);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, LAS3);
        //new Chord(stream1, N8, LA3);    
        //#endregion

        //#region Section 3
        //new Chord(stream1, (N4 / 16.0f) / 3.0f, SO3);
        //new Chord(stream1, (N4 / 16.0f) / 3.0f, MI4);
        //new Chord(stream1, (N4 / 16.0f) / 3.0f, SO4);
        //new Chord(stream1, N8, LA4);
        //new Chord(stream1, N16, FA4);
        //new Chord(stream1, N16, SO4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, MI4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, RE4);
        //new Chord(stream1, N16, SI3);
        //new Chord(stream1, N8, Silence);
        //#endregion

        //#region Section 4
        //new Chord(stream1, N8, DO4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, SO3);
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N8, MI3);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, SI3);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, LAS3);
        //new Chord(stream1, N8, LA3);
        //#endregion

        //#region Section 5
        //new Chord(stream1, (N4 / 16.0f) / 3.0f, SO3);
        //new Chord(stream1, (N4 / 16.0f) / 3.0f, MI4);
        //new Chord(stream1, (N4 / 16.0f) / 3.0f, SO4);
        //new Chord(stream1, N8, LA4);
        //new Chord(stream1, N16, FA4);
        //new Chord(stream1, N16, SO4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, MI4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, RE4);
        //new Chord(stream1, N16, SI3);
        //new Chord(stream1, N8, Silence);
        //#endregion
        
        //#region Section 6
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N16, SO4);
        //new Chord(stream1, N16, FAS4);
        //new Chord(stream1, N16, FA4);
        //new Chord(stream1, N8, RES4);
        //new Chord(stream1, N16, MI4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, SOS3);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, RE4);
        //#endregion

        //#region Section 7
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N16, SO4);
        //new Chord(stream1, N16, FAS4);
        //new Chord(stream1, N16, FA4);
        //new Chord(stream1, N8, RES4);
        //new Chord(stream1, N16, MI4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, FA4, DO5);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, FA4, DO5);
        //new Chord(stream1, N4, FA4, DO5).SetStaccato(true);
        //#endregion

        //#region Section 8
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N16, SO4);
        //new Chord(stream1, N16, FAS4);
        //new Chord(stream1, N16, FA4);
        //new Chord(stream1, N8, RES4);
        //new Chord(stream1, N16, MI4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, SOS3);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, RE4);
        //#endregion

        //#region Section 9
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N8, RES4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, RE4);
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N4, DO4).SetStaccato(true);
        //new Chord(stream1, N4, Silence);
        //#endregion

        //#region Section 10
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N16, SO4);
        //new Chord(stream1, N16, FAS4);
        //new Chord(stream1, N16, FA4);
        //new Chord(stream1, N8, RES4);
        //new Chord(stream1, N16, MI4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, SOS3);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, RE4);
        //#endregion

        //#region Section 11
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N16, SO4);
        //new Chord(stream1, N16, FAS4);
        //new Chord(stream1, N16, FA4);
        //new Chord(stream1, N8, RES4);
        //new Chord(stream1, N16, MI4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, FA4, DO5);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, FA4, DO5);
        //new Chord(stream1, N4, FA4, DO5).SetStaccato(true);
        //#endregion

        //#region Section 12
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N16, SO4);
        //new Chord(stream1, N16, FAS4);
        //new Chord(stream1, N16, FA4);
        //new Chord(stream1, N8, RES4);
        //new Chord(stream1, N16, MI4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, SOS3);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, LA3);
        //new Chord(stream1, N16, DO4);
        //new Chord(stream1, N16, RE4);
        //#endregion

        //#region Section 13
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N8, RES4);
        //new Chord(stream1, N16, Silence);
        //new Chord(stream1, N16, RE4);
        //new Chord(stream1, N8, Silence);
        //new Chord(stream1, N4, DO4).SetStaccato(true);
        //new Chord(stream1, N4, Silence);
        //#endregion

        #region Section 14
        new Chord(stream1, N16, DO4);
        new Chord(stream1, N8, DO4);
        new Chord(stream1, N16, DO4);
        new Chord(stream1, N16, Silence);
        new Chord(stream1, N16, DO4);
        new Chord(stream1, N8, RE4);
        new Chord(stream1, N16, MI4);
        new Chord(stream1, N8, DO4);
        new Chord(stream1, N16, LA3);
        new Chord(stream1, N4, SO3).SetStaccato(true);

        #endregion

        #endregion

        #region Page 2
        new Chord(stream1, N16, DO4);
        new Chord(stream1, N8, DO4);
        new Chord(stream1, N16, DO4);
        new Chord(stream1, N16, Silence);
        new Chord(stream1, N16, DO4);
        new Chord(stream1, N16, RE4);
        new Chord(stream1, N16, MI4);
        new Chord(stream1, N2, Silence);

        #region Section 15

        #endregion

        #endregion

        #endregion

        stream1.ParentSong = song;
        song.ChordStreams.Add(stream1);

        var stream2 = new ChordStream();
        
        #region Left Hand

        #region Page 1

        //#region Section 1
        //new Chord(stream2, N16, RE2);
        //new Chord(stream2, N8, RE2);
        //new Chord(stream2, N16, RE2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, RE2);
        //new Chord(stream2, N8, RE2);
        //new Chord(stream2, N4, SO2).SetStaccato(true);
        //new Chord(stream2, N4, SO1).SetStaccato(true);
        //#endregion

        //#region Section 2
        //new Chord(stream2, N8, SO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, MI2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, FA2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, FAS2);
        //new Chord(stream2, N8, FA2);
        //#endregion

        //#region Section 3
        //new Chord(stream2, (N4 / 16.0f) / 3.0f, MI2);
        //new Chord(stream2, (N4 / 16.0f) / 3.0f, DO3);
        //new Chord(stream2, (N4 / 16.0f) / 3.0f, MI3);
        //new Chord(stream2, N8, FA3);
        //new Chord(stream2, N16, RE3);
        //new Chord(stream2, N16, MI3);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, LA2);
        //new Chord(stream2, N16, SI2);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N8, Silence);
        //#endregion

        //#region Section 4
        //new Chord(stream2, N8, SO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, MI2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, FA2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, FAS2);
        //new Chord(stream2, N8, FA2);
        //#endregion

        //#region Section 5
        //new Chord(stream2, (N4 / 16.0f) / 3.0f, MI2);
        //new Chord(stream2, (N4 / 16.0f) / 3.0f, DO3);
        //new Chord(stream2, (N4 / 16.0f) / 3.0f, MI3);
        //new Chord(stream2, N8, FA3);
        //new Chord(stream2, N16, RE3);
        //new Chord(stream2, N16, MI3);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, LA2);
        //new Chord(stream2, N16, SI2);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N8, Silence);
        //#endregion

        //#region Section 6
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, DO3);
        //new Chord(stream2, N8, FA2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N8, FA2);
        //#endregion

        //#region Section 7
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, MI2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N4, Silence);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, SO2);
        //#endregion

        //#region Section 8
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, DO3);
        //new Chord(stream2, N8, FA2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N8, FA2);
        //#endregion

        //#region Section 9
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N8, SOS2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, LAS2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, DO3);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, SOS2);
        //new Chord(stream2, N8, SOS2);
        //new Chord(stream2, N8, DO2);
        //#endregion

        //#region Section 10
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, DO3);
        //new Chord(stream2, N8, FA2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N8, FA2);
        //#endregion

        //#region Section 11
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, MI2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N4, Silence);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, SO2);
        //#endregion

        //#region Section 12
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, SO2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, DO3);
        //new Chord(stream2, N8, FA2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N16, DO3);
        //new Chord(stream2, N8, FA2);
        //#endregion

        //#region Section 13
        //new Chord(stream2, N8, DO2);
        //new Chord(stream2, N8, SOS2);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, LAS2);
        //new Chord(stream2, N8, Silence);
        //new Chord(stream2, N8, DO3);
        //new Chord(stream2, N16, Silence);
        //new Chord(stream2, N16, SOS2);
        //new Chord(stream2, N8, SOS2);
        //new Chord(stream2, N8, DO2);
        //#endregion

        #region Section 14
        new Chord(stream2, N8, SOS1);
        new Chord(stream2, N16, Silence);
        new Chord(stream2, N16, RES2);
        new Chord(stream2, N8, Silence);
        new Chord(stream2, N8, SOS2);
        new Chord(stream2, N8, SO2);
        new Chord(stream2, N16, Silence);
        new Chord(stream2, N16, DO2);
        new Chord(stream2, N8, Silence);
        new Chord(stream2, N8, SO1);
        #endregion

        #endregion

        #region Page 2

        #region Section 15
        new Chord(stream2, N8, SOS1);
        new Chord(stream2, N16, Silence);
        new Chord(stream2, N16, RES2);
        new Chord(stream2, N8, Silence);
        new Chord(stream2, N8, SOS2);
        new Chord(stream2, N8, SO2);
        new Chord(stream2, N16, Silence);
        new Chord(stream2, N16, DO2);
        new Chord(stream2, N8, Silence);
        new Chord(stream2, N16, SO1);
        #endregion

        #endregion

        #endregion

        stream2.ParentSong = song;
        song.ChordStreams.Add(stream2);

        return song;
    }
}
