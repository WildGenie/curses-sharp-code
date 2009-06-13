/*
 * CursesSharp
 * 
 * Copyright 2009 Robert Konklewski
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or (at your
 * option) any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public
 * License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * www.gnu.org/licenses/>.
 * 
 */

#include "wrapper.h"

/*
  Name:								beep

  Synopsis:
	int beep(void);
	int flash(void);

  Return Value:
	These functions return OK.

  Portability				     X/Open    BSD    SYS V
	beep					Y	Y	Y
	flash					Y	Y	Y
*/

int
wrap_beep(void)
{
	return beep();
}

int
wrap_flash(void)
{
	return flash();
}
