using Godot;
using System;

public partial class Enemies : Node2D
{
    float time = 0.0f;
	RandomNumberGenerator rng = new RandomNumberGenerator();

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{

		if (time > rng.RandfRange(3, 12))
		{

			PackedScene packedScene = ResourceLoader.Load<PackedScene>("res://prefabs/spawn.tscn");
			var Enemy = packedScene.Instantiate();
			AddChild(Enemy);
            time = 0.0f;
		}
        time += (float)delta;
    }
}
