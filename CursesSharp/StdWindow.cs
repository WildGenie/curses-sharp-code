using System;

namespace Curses
{
    internal class StdWindow : IWindow
    {
        private IntPtr stdscr;

        internal StdWindow(IntPtr stdscr)
        {
            this.stdscr = stdscr;
        }

        #region IWindow Members

        public void AddCh(char ch)
        {
            if (NativeMethods.wrap_addch((ushort)ch) != 0)
                throw new CursesException("addch() failed.");
        }

        public void AddCh(uint ch)
        {
            if (NativeMethods.wrap_addch(ch) != 0)
                throw new CursesException("addch() failed.");
        }

        public void MvAddCh(int y, int x, char ch)
        {
            if (NativeMethods.wrap_mvaddch(y, x, (ushort)ch) != 0)
                throw new CursesException("mvaddch() failed.");
        }

        public void MvAddCh(int y, int x, uint ch)
        {
            if (NativeMethods.wrap_mvaddch(y, x, ch) != 0)
                throw new CursesException("mvaddch() failed.");
        }

        public void AddStr(string str)
        {
            if (NativeMethods.wrap_addstr(str) != 0)
                throw new CursesException("addstr() failed.");
        }

        public void MvAddStr(int y, int x, string str)
        {
            if (NativeMethods.wrap_mvaddstr(y, x, str) != 0)
                throw new CursesException("mvaddstr() failed.");
        }

        public void AttrSet(uint attr)
        {
            if (NativeMethods.wrap_attrset(attr) != 0)
                throw new CursesException("attrset() failed.");
        }

        public void Erase()
        {
            if (NativeMethods.wrap_erase() != 0)
                throw new CursesException("erase() failed.");
        }

        public int GetCh()
        {
            return NativeMethods.wrap_getch();
        }

        public void Keypad(bool bf)
        {
            if (NativeMethods.wrap_keypad(this.stdscr, bf) != 0)
                throw new CursesException("keypad() failed.");
        }

        public void NoDelay(bool bf)
        {
            if (NativeMethods.wrap_nodelay(this.stdscr, bf) != 0)
                throw new CursesException("nodelay() failed.");
        }

        public void Move(int y, int x)
        {
            if (NativeMethods.wrap_move(y, x) != 0)
                throw new CursesException("move() failed.");
        }

        public void Refresh()
        {
            if (NativeMethods.wrap_refresh() != 0)
                throw new CursesException("refresh() failed.");
        }

        #endregion
    }
}
