using Godot;

namespace Nunu.Input
{
    public class ManagedPlayer : IPlayer
    {

        public bool IsInputReady { get; }

        public Vector2 GetInputDirection()
        {

            return new Vector2(0, 0);

        }

    }

}
