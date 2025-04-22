using GameFlow;
using GameFlow.States;
using Services;
using Services.Factory;
using UI;
using Unity.VisualScripting;
using UnityEngine;

namespace Core
{
    public static class GameInstaller
    {
        public static DIContainer Container { get; private set; }

        public static void Install()
        {
            Container = new DIContainer();

            Container.Register(new SaveSystem());
            Container.Register(new EventBus());
            Container.Register(new GameStateMachine());

            Container.Register(ServiceFactory.CreateCurtain());

            Container.Resolve<GameStateMachine>().EnterState(new BootstrapState());
        }
    }
}
