using Godot;

namespace Nunu.Input
{

    // The player, most likely Nunu herself in the flesh
    public class HumanPlayer : IPlayer
    {

        public bool IsInputReady { get => false; }

        public Vector2 GetInputDirection()
        {

            return new Vector2(0, 0);

        }

    }

}
