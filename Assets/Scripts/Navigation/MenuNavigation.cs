using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum ModuleType
{
    Main,
    Game
}

public static class MenuNavigation
{
    private static ModuleType _currentModule = ModuleType.Main;

    public static void OpenModule(ModuleType type)
    {
        if (_currentModule == type)
        {
            return;
        }
        _currentModule = type;

        switch (type)
        {
            case ModuleType.Main:
                SceneManager.LoadScene("MainScene");
                return;
            case ModuleType.Game:
                SceneManager.LoadScene("GameScene");
                return;
        }
    }
}
