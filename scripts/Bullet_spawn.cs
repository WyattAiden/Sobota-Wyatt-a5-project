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
           RigidBody2D bullet = bullet_scene.Instantiate<RigidBody2D>();//tells it what to spawn

            bullet.Rotation = GlobalRotation;//tells the node what way the bullet should be facing when it spawns 
            bullet.GlobalPosition = GlobalPosition;//tells the node where to spawn the bullet
            bullet.LinearVelocity = bullet.Transform.X * bullet_speed;//tells the node how fast the bullet should be moving when it spawns

            GetTree().Root.AddChild(bullet);//spawns the bullet

            Time_till_shoot = 0f;
        }
        else
        {
            Time_till_shoot += (float)delta;
        }
    }

}
