using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class SaveState
{
    #region Money

    public int Money;

    #endregion
    
    #region Preferences
    public bool IsSoundOn;
    public bool IsVibrationOn;
    public bool IsNoAdsOn;
    #endregion
    
    public void SetInitValues()
    {
        #region Money
        Money = 0;
        #endregion
        
        #region Preferences
        IsSoundOn = true;
        IsVibrationOn = true;
        IsNoAdsOn = false;
        #endregion
    }
}