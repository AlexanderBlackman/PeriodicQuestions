﻿using PeriodicQuestions.Helpers;
using System;
using System.Threading;

namespace PeriodicQuestions.ActiveWindow
{
    public class PeriodicWindowWatcher
    {
        private PeriodicTimer stateTimer;




        private ActiveWindowModel currentActiveWindow = ActiveWindowModel.CreateEmpty();
        public event EventHandler<ActiveWindowChangedEventArgs> ActiveWindowChanged;

        public PeriodicWindowWatcher(TimeSpan interval)
        {
            InitialiseTimer(interval);
        }

        public async void InitialiseTimer(TimeSpan interval)
        {
            stateTimer = new PeriodicTimer(interval);
            while (await stateTimer.WaitForNextTickAsync())
            {
                GetActiveWindow();
            }
        }

        private void GetActiveWindow() =>
            WindowAPI
                .GetActiveWindowTitle()
                .Do(activeWindow =>
                    activeWindow.IsDifferentThan(currentActiveWindow, () =>
                    {
                        currentActiveWindow = ActiveWindowModel.CreateFrom(activeWindow);
                        ActiveWindowChanged?.Invoke(this, ActiveWindowChangedEventArgs.Create(activeWindow.WindowTitle));
                    }));
    }
}
