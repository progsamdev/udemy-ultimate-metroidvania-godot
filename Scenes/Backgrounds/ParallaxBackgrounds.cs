using Godot;
using System;



public partial class ParallaxBackgrounds : ParallaxBackground
{
    
    private float ScrollSpeed = 100f;

    public override void _Ready()
    {
        // Initialization code can go here if needed
    }

    public override void _Process(double delta)
    {
        // Move the background layers to create a parallax scrolling effect
        this.ScrollOffset += new Vector2(ScrollSpeed * (float)delta, 0);
        
    }

}
