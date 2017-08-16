﻿//****************************************************************************
// Description:
// Author: hiramtan@live.com
//****************************************************************************

namespace HiFramework
{
    public interface IController
    {
        /// <summary>
        /// bind its view
        /// </summary>
        /// <param name="param"></param>
        void Bind(IView param);

        /// <summary>
        /// dispatch message to view
        /// </summary>
        /// <param name="param"></param>
        void Dispatch(Message param);
    }
}