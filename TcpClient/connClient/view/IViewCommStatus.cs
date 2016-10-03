﻿namespace bitkyFlashresUniversal.connClient.view
{
    internal interface IViewCommStatus
    {
        /// <summary>
        ///     控制信息的显示
        /// </summary>
        /// <param name="message">输入所需显示的信息</param>
        void ControlMessageShow(string message);

        /// <summary>
        ///     通信信息的显示
        /// </summary>
        /// <param name="message">输入所需显示的信息</param>
        void CommunicateMessageShow(string message);

        /// <summary>
        ///     数据库数据轮廓信息显示
        /// </summary>
        /// <param name="message"></param>
        void DataOutlineShow(string message);

        /// <summary>
        ///     连接正在建立中
        /// </summary>
        void ConnConnecting();

        /// <summary>
        ///     网络连接已建立
        /// </summary>
        void ConnConnected();

        /// <summary>
        ///     网络连接已断开
        /// </summary>
        void ConnDisconnected();

        /// <summary>
        ///     电极信息初始化成功
        /// </summary>
        void SetElectrodeSuccessful();
    }
}