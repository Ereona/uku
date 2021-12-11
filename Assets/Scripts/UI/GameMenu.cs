using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    private Text _textField;
    [SerializeField]
    private Button _backButton;

    private void Start()
    {
        _textField.text = GameVariables.TextFieldValue;
        _backButton.onClick.AddListener(OnBackButtonClick);
    }

    private void OnBackButtonClick()
    {
        MenuNavigation.OpenModule(ModuleType.Main);
    }

    private void OnDestroy()
    {
        _backButton.onClick.RemoveListener(OnBackButtonClick);
    }
}
