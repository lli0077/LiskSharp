﻿#region copyright
// <copyright file="BaseResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LiskSharp.Core.Api.Messages.Common
{
    /// <summary>
    /// Base response class for all the api response classes. Every api response object should be inherited from this class.
    /// </summary>
    [DataContract]
    public abstract class BaseResponse
    {
        [DataMember(Name = "success", Order = 1, EmitDefaultValue = false)]
        public bool Success { get; set; }

        [DataMember(Name = "error", Order = 2, EmitDefaultValue = false, IsRequired = false)]
        public string Error { get; set; }

        public override string ToString()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            return JsonConvert.SerializeObject(this, settings);
        }
    }
}
