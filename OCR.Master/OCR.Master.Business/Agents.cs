
using OCR.Common.Model;
using OCR.Common.Utilities;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OCR.Master.Business
{
    public class Agents : List<AgentConfig>
    {
        #region Private Members
        private string _configLocation;
        private void AddToConfig(AgentConfig agentConfig)
        {
            FileIO.Write(_configLocation, JSONIO.ToJSON<ReadOnlyCollection<AgentConfig>>(base.AsReadOnly()));
        }
        #endregion

        public Agents(string configLocation)
        {
            _configLocation = configLocation;
        }

        public new AgentConfig Add(AgentConfig agentConfig)
        {
            base.Add(agentConfig);
            return agentConfig;
        }

    }
}
