﻿/****************************************************************************
 * Description: 
 * 
 * Document: https://github.com/hiramtan/HiFramework.Unity
 * Author: hiramtan@live.com
 ****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiFramework;

namespace HiFramework.Unity
{
    public abstract class TaskBase<T> : ITick
    {
        private IAsyncTaskComponent _asyncTaskComponent;

        protected Action<T> Action { get; private set; }

        protected TaskBase(Action<T> action)
        {
            _asyncTaskComponent = Center.Get<IAsyncTaskComponent>();
            _asyncTaskComponent.AddTask(this);
            Action = action;
        }

        protected void Finish()
        {
            _asyncTaskComponent.RemoveTask(this);
        }

        public abstract void Tick(float time);
    }
}