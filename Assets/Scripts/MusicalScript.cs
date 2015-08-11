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
    #endregion

    protected SoundPoolController SoundPool { get { return SoundPoolController.sInstance; } }

    
    public static Song GetMarioTheme()
    {
        var song = new Song();

        var stream1 = new ChordStream();

        #region Right Hand

        new Chord(stream1, NoteLength.Sixteenth, MI3);
        new Chord(stream1, NoteLength.Eighth, MI3);
        new Chord(stream1, NoteLength.Sixteenth, MI3);

        #endregion

        stream1.ParentSong = song;
        song.ChordStreams.Add(stream1);

        //var stream2 = new ChordStream();
        //
        //#region Left Hand
        //
        //
        //
        //#endregion
        //
        //stream2.ParentSong = song;
        //song.ChordStreams.Add(stream2);

        return song;
    }
}
