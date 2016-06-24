﻿#region copyright
// <copyright file="BlockRequest.cs" >
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
    /// BlockRequest is used 
    /// </summary>
    public class BlockRequest : BaseRequest
    {
        [QueryParam(Name="id")]
        public string Id { get; set; }
    }
}
