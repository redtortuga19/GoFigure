﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

public class Character : GameObject
{
	private int maxSpeed
	{
		get;
		set;
	}

	public bool dead
	{
		get;
		set;
	}

	private int jumpHeight
	{
		get;
		set;
	}

    private int currentSpeed
    {
        get;
        set;
    }

    public virtual void changeSpeed(int speed)
    {
        if (currentSpeed <= maxSpeed) {
            currentSpeed += speed;
        }
    }

    public Character(Image image, PointF point)
	{
        this.image = image;
        this.point = point;
	}

}

