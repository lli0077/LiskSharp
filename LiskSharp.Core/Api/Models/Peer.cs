﻿#region copyright
// <copyright file="Peer.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LiskSharp.Core.Api.Models
{
    [DataContract]
    public class Peer
    {
        [DataMember(Name = "ip")]
        public string IpAddress { get; set; }

        [DataMember(Name = "port")]
        public int Port { get; set; }

        //todo: change to enum
        [DataMember(Name = "state")]
        public int State { get; set; }

        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "os")]
        public string Os { get; set; }
    }
}
