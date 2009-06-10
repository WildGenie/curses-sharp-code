using System;

namespace Curses
{
    public static class Screen
    {
        private static StdWindow stdscr;

        public static IWindow StdScr
        {
            get { return stdscr; }
        }

        public static IWindow InitScr()
        {
            if (stdscr != null)
                throw new InvalidOperationException("Curses is already initialized.");

            IntPtr winptr = NativeMethods.wrap_initscr();
            if (winptr == IntPtr.Zero)
                throw new CursesException("initscr() failed.");

            stdscr = new StdWindow(winptr);
            return stdscr;
        }

        public static void EndWin()
        {
            if (stdscr == null)
                throw new InvalidOperationException("Curses is not initialized.");
            if (NativeMethods.wrap_endwin() != 0)
                throw new CursesException("endwin() failed.");
            stdscr = null;
        }

        public static uint COLOR_PAIR(short n)
        {
            return NativeMethods.wrap_COLOR_PAIR(n);
        }

        public static short PAIR_NUMBER(uint n)
        {
            return NativeMethods.wrap_PAIR_NUMBER(n);
        }

        public static void StartColor()
        {
            if (NativeMethods.wrap_start_color() != 0)
                throw new CursesException("start_color() failed.");
        }

        public static bool HasColors()
        {
            return NativeMethods.wrap_has_colors();
        }

        public static void InitPair(short color, short fg, short bg)
        {
            if (NativeMethods.wrap_init_pair(color, fg, bg) != 0)
                throw new CursesException("init_pair() failed.");
        }

        public static void Echo()
        {
            if (NativeMethods.wrap_echo() != 0)
                throw new CursesException("echo() failed.");
        }

        public static void NoEcho()
        {
            if (NativeMethods.wrap_noecho() != 0)
                throw new CursesException("noecho() failed.");
        }

        public static void Raw()
        {
            if (NativeMethods.wrap_raw() != 0)
                throw new CursesException("raw() failed.");
        }

        public static void NoRaw()
        {
            if (NativeMethods.wrap_noraw() != 0)
                throw new CursesException("noraw() failed.");
        }

        public static void NapMs(int ms)
        {
            if (NativeMethods.wrap_napms(ms) != 0)
                throw new CursesException("napms() failed.");
        }
    }
}
