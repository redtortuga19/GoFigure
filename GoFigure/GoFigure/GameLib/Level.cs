﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Level
{
	private string filename
	{
		get;
		set;
	}

	private IEnumerable<string> soundEffets
	{
		get;
		set;
	}

	private IEnumerable<GameObject> layout
	{
		get;
		set;
	}

	private Clock timer
	{
		get;
		set;
	}

	public virtual Clock Clock
	{
		get;
		set;
	}

	public virtual bool loadLevel()
	{
		throw new System.NotImplementedException();
	}

	public virtual bool saveLevel()
	{
		throw new System.NotImplementedException();
	}

	private bool levelExisit()
	{
		throw new System.NotImplementedException();
	}

	public virtual IEnumerable<int> checkLocation(int x, int y)
	{
		throw new System.NotImplementedException();
	}

	public Level(string filename)
	{
	}

	private bool checkReadOnly()
	{
		throw new System.NotImplementedException();
	}

	public virtual Cell characterLocation()
	{
		throw new System.NotImplementedException();
	}

	public virtual IEnumerable<GameObject> shapesAroundCharacter()
	{
		throw new System.NotImplementedException();
	}

	public virtual GameObject shapeAt(int x, int y)
	{
		throw new System.NotImplementedException();
	}

}

