﻿#region copyright
// <copyright file="DelegateVoteAsset.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class DelegateVoteAsset : Asset
    {
        [DataMember(Name = "votes")]
        public List<string> Votes = new List<string>();

        public override byte[] GetBytes()
        {

			using (MemoryStream stream = new MemoryStream())
			{
				using (BinaryWriter writer = new BinaryWriter(stream))
				{
					foreach (var vote in Votes)
					{
						writer.Write(vote);
					}
				}
				return stream.ToArray();
			}
        }
    }
}
