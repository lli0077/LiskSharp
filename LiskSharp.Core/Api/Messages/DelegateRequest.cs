﻿#region copyright
// <copyright file="DelegateRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages
{
    /// <summary>
    /// Delegate request 
    /// </summary>
    public class DelegateRequest : BaseRequest
    {
        [QueryParam(Name = "transactionId")]
        public string TransactionId { get; set; }

        [QueryParam(Name="username")]
        public string Username { get; set; }

        [QueryParam(Name="publicKey")]
        public string PublicKey { get; set; }

    }
}
