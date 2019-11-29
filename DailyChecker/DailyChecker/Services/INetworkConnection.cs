using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChecker.Services
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
        void CheckInternetConnection();
    }
}
