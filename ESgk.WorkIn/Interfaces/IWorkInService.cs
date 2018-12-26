using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using ESgk.WorkIn.Model;

namespace ESgk.WorkIn.Interfaces
{
    [ServiceContract]
    public interface IWorkInService
    {


        [OperationContract]
        [WebInvoke(UriTemplate = "WorkIn",
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string GetWorkInStatus(WorkInQueriesModel workInQueriesModel);

    }
}
