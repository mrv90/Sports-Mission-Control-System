using smcs.backend.data.model;
using smcs.backend.data.model.parent;
using System;

namespace smcs.backend.biz
{
    [Obsolete("طراحی کلاس پیاده‌کننده را بدون ایجاد ارزش افزوده، پیچیده می‌کند", true)]
    public interface IBizProvider 
    {
        void Login(string usrNam, string pass);
        void Logout();
        
        void RegisterTheAgent(Mission mis, Agent agnt);
        void DismissTheAgent(Agent agnt, DateTime retToUnt);
        
        void RegisterTheAgentOnOffice(Agent agnt, Int32 offcId);
        void RemoveOfficeOfAgent(Agent agnt);
        
        void WriteTheAgentsIteration<T>(Int32 agId, DateTime date) where T : Iterative;
        
        void RemoveTheAgentsIteration<T>(Int32 agId, DateTime date) where T : Iterative;
    }
}
