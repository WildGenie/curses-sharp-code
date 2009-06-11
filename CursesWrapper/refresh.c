#include <curses.h>

/*
  Name:								refresh

  Synopsis:
	int refresh(void);
	int wrefresh(WINDOW *win);
	int wnoutrefresh(WINDOW *win);
	int doupdate(void);
	int redrawwin(WINDOW *win);
	int wredrawln(WINDOW *win, int beg_line, int num_lines);

  Return Value:
	All functions return OK on success and ERR on error.

  Portability				     X/Open    BSD    SYS V
	refresh					Y	Y	Y
	wrefresh				Y	Y	Y
	wnoutrefresh				Y	Y	Y
	doupdate				Y	Y	Y
	redrawwin				Y	-      4.0
	wredrawln				Y	-      4.0
*/

int 
wrap_wrefresh(WINDOW *win)
{
	return wrefresh(win);
}

int 
wrap_wnoutrefresh(WINDOW *win)
{
	return wnoutrefresh(win);
}

int 
wrap_doupdate(void)
{
	return doupdate();
}

int 
wrap_redrawwin(WINDOW *win)
{
	return redrawwin(win);
}

int 
wrap_wredrawln(WINDOW *win, int beg_line, int num_lines)
{
	return wredrawln(win, beg_line, num_lines);
}
