﻿#region copyright
// <copyright file="DelegatesResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System.Collections.Generic;
using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Node
{
    [DataContract]
    public class DelegatesResponse : BaseResponse
    {
        [DataMember(Name = "delegates", Order = 2)]
        public List<Delegate> Delegates { get; set; }

        [DataMember(Name = "totalcount", Order = 3)]
        public int TotalCount { get; set; }
    }
}
