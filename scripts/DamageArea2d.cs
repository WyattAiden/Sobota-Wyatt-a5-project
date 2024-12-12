using Godot;
using System;
using System.Reflection.Emit;

public partial class DamageArea2d : Area2D
{
    int BaseHp = 100;
    [Export] Godot.Label BaseHp_label;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        AreaEntered += Base_BodyEntered;
    }

    private void Base_BodyEntered(Area2D body)
    {
        BaseHp -= 10;
        if (BaseHp <= 0)
        {

        }
        body.QueueFree();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        BaseHp_label.Text = $"HP:{BaseHp}";
    }
}

