using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButtonClick;
    
    public override void Open()
    {
        canvasGroup.alpha = 1;
        button.interactable = true;
    }

    public override void Close()
    {
        canvasGroup.alpha = 0;
        button.interactable = false;
    }
    
    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke();
    }
}
