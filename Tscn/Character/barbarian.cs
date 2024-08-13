using Godot;
using System;

public partial class barbarian : CharacterBody3D
{
	private Character thisChar;
	private int Speed = 10;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		thisChar = new Character("Babarian", 20, 10, 15);
	}

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(double delta)
    {
        
    }
}
