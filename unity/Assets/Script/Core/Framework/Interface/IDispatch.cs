﻿//****************************************************************************
// Description:
// Author: hiramtan@live.com
//****************************************************************************
namespace HiFramework
{
    public interface IDispatch
    {
        void Dispatch(object paramKey, Message paramMessage = null);
    }
}