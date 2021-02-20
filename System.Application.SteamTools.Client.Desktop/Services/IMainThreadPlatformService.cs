﻿namespace System.Application.Services
{
    /// <summary>
    /// 由平台实现的主线程帮助类
    /// </summary>
    public interface IMainThreadPlatformService
    {
        bool PlatformIsMainThread { get; }

        void PlatformBeginInvokeOnMainThread(Action action);

        public static IMainThreadPlatformService Instance => DI.Get<IMainThreadPlatformService>();
    }
}