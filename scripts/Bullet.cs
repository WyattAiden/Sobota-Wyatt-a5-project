using Godot;
using System;

public partial class Bullet : RigidBody2D
{
    public override void _Process(double delta)
    {
        var viewportRect = GetViewport().GetVisibleRect();
        // Add a small margin to prevent premature deletion at edges
        var expandedViewportRect = viewportRect.Grow(10);

        if (!expandedViewportRect.HasPoint(GlobalPosition))
        {
            QueueFree(); // Delete the bullet when out of bounds
        }
    }
}
