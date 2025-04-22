using Core;
using Services;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    private void Start()
    {
        CurtainService curtain = GameInstaller.Container.Resolve<CurtainService>();
        curtain.Hide();
    }
}
