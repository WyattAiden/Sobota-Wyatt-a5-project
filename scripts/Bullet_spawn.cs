using Godot;
using System;

public partial class Bullet_spawn : Node2D
{
    [Export] PackedScene bullet_scene;
    [Export] float bullet_speed = 600F;
    [Export] float SS = 3f;

    float Fire_rate;

    float Time_till_shoot = 0f;

    public override void _Ready()
    {
        Fire_rate = 1/SS;
    }

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("fire_gun")&& Time_till_shoot > Fire_rate)
        {
           RigidBody2D bullet = bullet_scene.Instantiate<RigidBody2D>();

            bullet.Rotation = GlobalRotation;
            bullet.GlobalPosition = GlobalPosition;
            bullet.LinearVelocity = bullet.Transform.X * bullet_speed;

            GetTree().Root.AddChild(bullet);

            Time_till_shoot = 0f;
        }
        else
        {
            Time_till_shoot += (float)delta;
        }
    }

}
