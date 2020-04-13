using Godot;
using System;

namespace Nunu.Overworld
{

    //Class that represents any character entity in the overworld
    public abstract class OverworldPlayerEntity : OverworldEntity
    {

        public Nunu.Input.IPlayer controller;

        // Called when the node enters the scene tree for the first time.
        public override void _Ready()
        {
            
        }

        //  // Called every frame. 'delta' is the elapsed time since the previous frame.
        //  public override void _Process(float delta)
        //  {
        //      
        //  }

        protected override void ProcessOverworld(float delta)
        {

        }

    }

}