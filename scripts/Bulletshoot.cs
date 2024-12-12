using Godot;
using System;

public partial class Bulletshoot : Node2D
{
    public Vector2 Velocity = Vector2.Zero; // Movement velocity of the bullet

    public override void _Process(double delta)
    {
        // Move the bullet in the direction of its velocity
        Position += Velocity * (float)delta;
    }
}
