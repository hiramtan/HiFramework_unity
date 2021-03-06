﻿/****************************************************************************
 * Description: 
 * 
 * Document: https://github.com/hiramtan/HiFramework.Unity
 * Author: hiramtan@live.com
 ****************************************************************************/

using System.Collections.Generic;
using HiFramework;


namespace HiFramework.Unity
{
    class AsyncTaskComponent : ComponentBase, IAsyncTaskComponent, ITick
    {
        private ITickComponent _tickComponent;
        private List<ITick> _asyncTasks = new List<ITick>();

        public override void OnCreated()
        {
            _tickComponent = Center.Get<ITickComponent>();
            _tickComponent.Regist(this);
        }

        public override void OnDestroy()
        {
            _tickComponent.Unregist(this);
        }

        public void Tick(float time)
        {
            for (int i = 0; i < _asyncTasks.Count; i++)
            {
                _asyncTasks[i].Tick(time);
            }
        }

        public void AddTask(ITick task)
        {
            Assert.IsFalse(_asyncTasks.Contains(task), "task already exist");
            _asyncTasks.Add(task);
        }

        public void RemoveTask(ITick task)
        {
            Assert.IsTrue(_asyncTasks.Contains(task), "task not exist");
            _asyncTasks.Remove(task);
        }
    }
}