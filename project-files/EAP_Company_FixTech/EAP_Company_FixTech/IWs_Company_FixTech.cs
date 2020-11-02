using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EAP_Company_FixTech
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWs_Company_FixTech" in both code and config file together.
    [ServiceContract]
    public interface IWs_Company_FixTech
    {
        [OperationContract]
        void DoWork();
    }
}
