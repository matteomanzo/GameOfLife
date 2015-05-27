﻿using System;

namespace GameOfLife
{
	public class Cell
	{
		private int _status;

		public Cell (int status = 0)
		{
			_status = status;
		}

		public bool isAlive ()
		{
			if (_status == 1) {
				return true;
			}

			return false;
		}
	}
}
