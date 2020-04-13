using Godot;
using System;

namespace Nunu.Overworld
{
    public abstract class OverworldEntity : Node 
    {

        //TODO move to game state manager
        public static bool OverworldViewActive;

        public abstract override void _Ready();

        public override void _Process(float delta)
        {
            if (OverworldViewActive) this.ProcessOverworld(delta);
        }

        protected abstract void ProcessOverworld(float delta);

    }

}