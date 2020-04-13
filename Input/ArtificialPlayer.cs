using Godot;

namespace Nunu.Input
{
    public class ArtificialPlayer : IPlayer
    {

        public bool IsInputReady { get => false; }

        public Vector2 GetInputDirection()
        {

            return new Vector2(0, 0);

        }

    }

}