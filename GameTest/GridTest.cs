﻿using NUnit.Framework;
using System;

namespace GameOfLife
{
	[TestFixture ()]
	public class GridTest
	{
		Grid grid;

		[SetUp]
		public void Init ()
		{
		    grid = new Grid (3, 3);	
		}

		[Test ()]
		public void ContainsCells()
		{
			Assert.IsInstanceOf<Cell> (grid.Contents(1, 2));
		}
			
	}
}