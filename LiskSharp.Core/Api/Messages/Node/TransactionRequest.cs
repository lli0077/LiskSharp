﻿#region copyright
// <copyright file="TransactionRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    public class TransactionRequest : BaseRequest
    {
        [QueryParam(Name="id")]
        public string Id { get; set; }
    }
}
