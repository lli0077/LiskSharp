﻿#region copyright
// <copyright file="HeaderValueAttribute.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System;

namespace LiskSharp.Core.Attributes
{
    /// <summary>
    /// QueryParamAttribute flags a property for including in request query parameters
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class HeaderValueAttribute : Attribute
    {
        public string Name { get; set; }

        public object Default { get; set; }
    }
}
