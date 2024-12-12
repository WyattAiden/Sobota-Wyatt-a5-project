using Godot;
using System;

public partial class Enemy : Area2D
{
    int Hp = 100;
    [Export] Label Hp_label;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        BodyEntered += Enemy_BodyEntered;
	}

    private void Enemy_BodyEntered(Node2D body)
    {
        Hp -= 10;
        if (Hp <= 0)
        {
            QueueFree();
        }
        body.QueueFree();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
        Hp_label.Text = $"{Hp}";
	}
}
