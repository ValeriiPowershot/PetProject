using Core;
using UnityEngine;

namespace GameFlow.States
{
    public class BootstrapState : IGameState
    {
        public void Enter()
        {
            Debug.Log("Bootstrap complete!");
        }

        public void Exit() { }
    }
}
