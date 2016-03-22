﻿using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceCL.Create
{
    [ServiceContract]
    public interface ICreateMemberService
    {
        [OperationContract]
        void CreateMemberServiceMethod(Member member);
    }
}
