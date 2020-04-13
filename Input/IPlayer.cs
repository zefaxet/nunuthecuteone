using System;
using Godot;

namespace Nunu.Input
{

    public interface IPlayer
    {

        bool IsInputReady { get; }

        Vector2 GetInputDirection();

    }

}