﻿using UnityEngine;
using System.Collections;

// UI观测Soldier阵亡事件
public class SoldierKilledObserverUI : IGameEventObserver 
{
    private SoldierKilledSubject m_Subject = null; // 主题
    private SoldierInfoUI m_InfoUI = null; //  要通知的界面

    public SoldierKilledObserverUI( SoldierInfoUI InfoUI  )
    {
        m_InfoUI = InfoUI;
    }

    // 设定观察的主题
    public override    void SetSubject( IGameEventSubject Subject )
    {
        m_Subject = Subject as SoldierKilledSubject;
    }

    // 通知Subject被更新
    public override void Update()
    {
        // 通知界面更新
        m_InfoUI.RefreshSoldier( m_Subject.GetSoldier() );
    }

}