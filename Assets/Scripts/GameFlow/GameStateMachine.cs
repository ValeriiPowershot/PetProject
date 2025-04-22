using Core;

namespace GameFlow
{
    public class GameStateMachine
    {
        private IGameState _currentState;

        public void EnterState(IGameState newState)
        {
            _currentState?.Exit();
            _currentState = newState;
            _currentState.Enter();
        }
    }

}