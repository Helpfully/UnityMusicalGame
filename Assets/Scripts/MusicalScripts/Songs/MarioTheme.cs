using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.MusicalScripts.Songs
{
    public static class MarioTheme
    {
        #region Note Constants
        const int Silence = -1, DO1 = 0, DO2 = 12, DO3 = 24, DO4 = 36, DO5 = 48,
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

        const int SPS = -1, N64 = 1, N32 = 2, N16 = 4, N8 = 8, N4 = 16, N2 = 32, N1 = 64;
        #endregion

        public static Song GetMarioTheme()
        {
            var song = new Song();
            song.PlaySpeed = 0.25f;

            var stream1 = new ChordStream();

            #region Right Hand

            #region Page 1
            
            RightSection1(stream1);
            RightSection2(stream1);
            RightSection3(stream1);
            RightSection2(stream1);
            RightSection3(stream1);
            RightSection6(stream1);
            RightSection7(stream1);
            RightSection6(stream1);
            RightSection9(stream1);
            RightSection6(stream1);
            RightSection7(stream1);
            RightSection6(stream1);
            RightSection9(stream1);
            RightSection14(stream1);

            #endregion

            #region Page 2

            RightSection15(stream1);
            RightSection14(stream1);
            RightSection1(stream1);
            RightSection2(stream1);
            RightSection3(stream1);
            RightSection2(stream1);
            RightSection3(stream1);
            RightSection22(stream1);
            RightSection23(stream1);
            RightSection22(stream1);
            RightSection25(stream1);
            RightSection22(stream1);
            RightSection23(stream1);
            RightSection22(stream1);
            RightSection25(stream1);
            RightSection14(stream1);
            RightSection15(stream1);
            RightSection14(stream1);
            
            #endregion

            #region Page 3

            RightSection1(stream1);
            RightSection22(stream1);
            RightSection23(stream1);
            RightSection22(stream1);
            RightSection25(stream1);
            RightSection38(stream1);
            RightSection39(stream1);

            #endregion

            #endregion

            stream1.ParentSong = song;
            song.ChordStreams.Add(stream1);

            var stream2 = new ChordStream();

            #region Left Hand

            #region Page 1

            LeftSection1(stream2);
            LeftSection2(stream2);
            LeftSection3(stream2);
            LeftSection2(stream2);
            LeftSection3(stream2);
            LeftSection6(stream2);
            LeftSection7(stream2);
            LeftSection6(stream2);
            LeftSection9(stream2);
            LeftSection6(stream2);
            LeftSection7(stream2);
            LeftSection6(stream2);
            LeftSection9(stream2);
            LeftSection14(stream2);

            #endregion

            #region Page 2

            LeftSection15(stream2);
            LeftSection14(stream2);
            LeftSection1(stream2);
            LeftSection2(stream2);
            LeftSection3(stream2);
            LeftSection2(stream2);
            LeftSection3(stream2);
            LeftSection22(stream2);
            LeftSection23(stream2);
            LeftSection22(stream2);
            LeftSection25(stream2);
            LeftSection22(stream2);
            LeftSection23(stream2);
            LeftSection22(stream2);
            LeftSection25(stream2);
            LeftSection14(stream2);
            LeftSection15(stream2);
            LeftSection14(stream2);
            
            #endregion

            #region Page 3

            LeftSection1(stream2);
            LeftSection22(stream2);
            LeftSection23(stream2);
            LeftSection22(stream2);
            LeftSection25(stream2);
            LeftSection38(stream2);
            LeftSection39(stream2);

            #endregion

            #endregion

            stream2.ParentSong = song;
            song.ChordStreams.Add(stream2);

            return song;
        }

        #region Sections


        private static void LeftSection39(ChordStream stream2)
        {
            #region Section 39
            new Chord(stream2, N1, DO2);
            #endregion
        }

        private static void RightSection39(ChordStream stream1)
        {
            #region Section 39
            new Chord(stream1, N8, MI3, SO3);
            new Chord(stream1, N8, RE3);
            new Chord(stream1, N1, MI3);
            #endregion
        }

        private static void LeftSection38(ChordStream stream2)
        {
            #region Section 38
            new Chord(stream2, N8, SO2).SetExtended(true);
            new Chord(stream2, N8, MI2).SetExtended(true);
            new Chord(stream2, N8, DO2);
            new Chord(stream2, N4, FA2);
            new Chord(stream2, N2, DOS1);
            #endregion
        }

        private static void RightSection38(ChordStream stream1)
        {
            #region Section 38
            new Chord(stream1, N8, DO4).SetExtended(true);
            new Chord(stream1, N8, SO3).SetExtended(true);
            new Chord(stream1, N8, MI3);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, LA3);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, SI3);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, LA3);
            new Chord(stream1, (N2 / 16.0f) / 3.0f, SOS3);
            new Chord(stream1, (N2 / 16.0f) / 3.0f, LAS3);
            new Chord(stream1, (N2 / 16.0f) / 3.0f, SOS3);
            #endregion
        }

        private static void LeftSection25(ChordStream stream2)
        {
            #region Section 25
            new Chord(stream2, N8, SO2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, SO2);
            new Chord(stream2, (N4 / 16.0f) / 3.0f, SO2);
            new Chord(stream2, (N4 / 16.0f) / 3.0f, LA2);
            new Chord(stream2, (N4 / 16.0f) / 3.0f, SI2);
            new Chord(stream2, N8, DO3);
            new Chord(stream2, N8, SO2);
            new Chord(stream2, N4, DO2).SetStaccato(true);
            #endregion
        }

        private static void RightSection25(ChordStream stream1)
        {
            #region Section 25
            new Chord(stream1, N16, SI3);
            new Chord(stream1, N8, FA4);
            new Chord(stream1, N16, FA4);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, FA4);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, MI4);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, RE4);
            new Chord(stream1, N16, DO4);
            new Chord(stream1, N8, SO3);
            new Chord(stream1, N16, SO3);
            new Chord(stream1, N4, DO3).SetStaccato(true);
            #endregion
        }

        private static void LeftSection23(ChordStream stream2)
        {
            #region Section23
            new Chord(stream2, N8, RE2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, FA2);
            new Chord(stream2, N8, SO2);
            new Chord(stream2, N8, SI2);
            new Chord(stream2, N8, SO2);
            new Chord(stream2, N8, SO2);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N8, SO2);
            #endregion
        }

        private static void RightSection23(ChordStream stream1)
        {
            #region Section 23
            new Chord(stream1, (N4 / 16.0f) / 3.0f, SI3);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, LA4);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, LA4);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, LA4);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, SO4);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, FA4);
            new Chord(stream1, N16, MI4);
            new Chord(stream1, N8, DO4);
            new Chord(stream1, N16, LA3);
            new Chord(stream1, N4, SO3).SetStaccato(true);
            #endregion
        }

        private static void LeftSection22(ChordStream stream2)
        {
            #region Section 22
            new Chord(stream2, N8, DO2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, SO2);
            new Chord(stream2, N8, SO2);
            new Chord(stream2, N8, DO3);
            new Chord(stream2, N8, FA2);
            new Chord(stream2, N8, FA2);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N8, FA2);
            #endregion
        }

        private static void RightSection22(ChordStream stream2)
        {
            #region Section 22
            new Chord(stream2, N16, MI4);
            new Chord(stream2, N8, DO4);
            new Chord(stream2, N16, SO3);
            new Chord(stream2, N8, Silence);
            new Chord(stream2, N8, SOS3);
            new Chord(stream2, N16, LA3);
            new Chord(stream2, N8, FA4);
            new Chord(stream2, N16, FA4);
            new Chord(stream2, N4, LA3).SetStaccato(true);
            #endregion
        }

        private static void LeftSection15(ChordStream stream2)
        {
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
            new Chord(stream2, N8, SO1);
            #endregion
        }

        private static void LeftSection14(ChordStream stream2)
        {
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
        }

        private static void LeftSection9(ChordStream stream2)
        {
            #region Section 9
            new Chord(stream2, N8, DO2);
            new Chord(stream2, N8, SOS2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, LAS2);
            new Chord(stream2, N8, Silence);
            new Chord(stream2, N8, DO3);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, SO2);
            new Chord(stream2, N8, SO2);
            new Chord(stream2, N8, DO2);
            #endregion
        }

        private static void LeftSection7(ChordStream stream2)
        {
            #region Section 7
            new Chord(stream2, N8, DO2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, MI2);
            new Chord(stream2, N8, Silence);
            new Chord(stream2, N16, SO2);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N4, Silence);
            new Chord(stream2, N8, Silence);
            new Chord(stream2, N8, SO2);
            #endregion
        }

        private static void LeftSection6(ChordStream stream2)
        {
            #region Section 6
            new Chord(stream2, N8, DO2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, SO2);
            new Chord(stream2, N8, Silence);
            new Chord(stream2, N8, DO3);
            new Chord(stream2, N8, FA2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N8, FA2);
            #endregion
        }

        private static void LeftSection3(ChordStream stream2)
        {
            #region Section 3
            new Chord(stream2, (N4 / 16.0f) / 3.0f, MI2);
            new Chord(stream2, (N4 / 16.0f) / 3.0f, DO3);
            new Chord(stream2, (N4 / 16.0f) / 3.0f, MI3);
            new Chord(stream2, N8, FA3);
            new Chord(stream2, N16, RE3);
            new Chord(stream2, N16, MI3);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, DO3);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, LA2);
            new Chord(stream2, N16, SI2);
            new Chord(stream2, N16, SO2);
            new Chord(stream2, N8, Silence);
            #endregion
        }

        private static void LeftSection2(ChordStream stream2)
        {
            #region Section 2
            new Chord(stream2, N8, SO2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, MI2);
            new Chord(stream2, N8, Silence);
            new Chord(stream2, N8, DO2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, FA2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, SO2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, FAS2);
            new Chord(stream2, N8, FA2);
            #endregion
        }

        private static void LeftSection1(ChordStream stream2)
        {
            #region Section 1
            new Chord(stream2, N16, RE2);
            new Chord(stream2, N8, RE2);
            new Chord(stream2, N16, RE2);
            new Chord(stream2, N16, Silence);
            new Chord(stream2, N16, RE2);
            new Chord(stream2, N8, RE2);
            new Chord(stream2, N4, SO2).SetStaccato(true);
            new Chord(stream2, N4, SO1).SetStaccato(true);
            #endregion
        }

        private static void RightSection15(ChordStream stream1)
        {
            #region Section 15
            new Chord(stream1, N16, DO4);
            new Chord(stream1, N8, DO4);
            new Chord(stream1, N16, DO4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, DO4);
            new Chord(stream1, N16, RE4);
            new Chord(stream1, N16, MI4);
            new Chord(stream1, N2, Silence);
            #endregion
        }

        private static void RightSection14(ChordStream stream1)
        {
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
        }

        private static void RightSection9(ChordStream stream1)
        {
            #region Section 9
            new Chord(stream1, N8, Silence);
            new Chord(stream1, N8, RES4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, RE4);
            new Chord(stream1, N8, Silence);
            new Chord(stream1, N4, DO4).SetStaccato(true);
            new Chord(stream1, N4, Silence);
            #endregion
        }

        private static void RightSection7(ChordStream stream1)
        {
            #region Section 7
            new Chord(stream1, N8, Silence);
            new Chord(stream1, N16, SO4);
            new Chord(stream1, N16, FAS4);
            new Chord(stream1, N16, FA4);
            new Chord(stream1, N8, RES4);
            new Chord(stream1, N16, MI4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, FA4, DO5);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, FA4, DO5);
            new Chord(stream1, N4, FA4, DO5).SetStaccato(true);
            #endregion
        }

        private static void RightSection6(ChordStream stream1)
        {
            #region Section 6
            new Chord(stream1, N8, Silence);
            new Chord(stream1, N16, SO4);
            new Chord(stream1, N16, FAS4);
            new Chord(stream1, N16, FA4);
            new Chord(stream1, N8, RES4);
            new Chord(stream1, N16, MI4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, SOS3);
            new Chord(stream1, N16, LA3);
            new Chord(stream1, N16, DO4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, LA3);
            new Chord(stream1, N16, DO4);
            new Chord(stream1, N16, RE4);
            #endregion
        }

        private static void RightSection3(ChordStream stream1)
        {
            #region Section 3
            new Chord(stream1, (N4 / 16.0f) / 3.0f, SO3);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, MI4);
            new Chord(stream1, (N4 / 16.0f) / 3.0f, SO4);
            new Chord(stream1, N8, LA4);
            new Chord(stream1, N16, FA4);
            new Chord(stream1, N16, SO4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, MI4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, DO4);
            new Chord(stream1, N16, RE4);
            new Chord(stream1, N16, SI3);
            new Chord(stream1, N8, Silence);
            #endregion
        }

        private static void RightSection2(ChordStream stream1)
        {
            #region Section 2
            new Chord(stream1, N8, DO4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, SO3);
            new Chord(stream1, N8, Silence);
            new Chord(stream1, N8, MI3);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, LA3);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, SI3);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, LAS3);
            new Chord(stream1, N8, LA3);
            #endregion
        }

        private static void RightSection1(ChordStream stream1)
        {
            #region Section 1
            new Chord(stream1, N16, MI4);
            new Chord(stream1, N8, MI4);
            new Chord(stream1, N16, MI4);
            new Chord(stream1, N16, Silence);
            new Chord(stream1, N16, DO4);
            new Chord(stream1, N8, MI4);
            new Chord(stream1, N4, SO4).SetStaccato(true);
            new Chord(stream1, N4, SO2).SetStaccato(true);
            #endregion
        }

        #endregion
    }
}
