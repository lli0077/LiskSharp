﻿#region copyright
// <copyright file="HttpExtensions.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LiskSharp.Core.Common;
using Newtonsoft.Json;

namespace LiskSharp.Core.Extensions
{
    public static class HttpExtensions
    {
        public static async Task<T> GetJsonAsync<T>(this HttpClient client, string url)
        {
            var result = await client.GetAsync(url);
            result.EnsureSuccessStatusCode();
            if (result.Content != null)
            {
                var json = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
            return default(T);
        }

        public static async Task PostJsonAsync<T>(this HttpClient client, string url, T req)
        {
            var result = await client.PostAsync(url, new StringContent(req.ToString(), Encoding.UTF8, "application/json"));
            result.EnsureSuccessStatusCode();
        }

        public static async Task<T2> PostJsonAsync<T1,T2>(this HttpClient client, string url, T1 req)
         {
            var result = await client.PostAsync(url, new StringContent(req.ToString(),Encoding.UTF8, "application/json"));
            result.EnsureSuccessStatusCode();
            if (result.Content != null)
            {
                var json = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T2>(json);
            }
            return default(T2);
        }

    }
}
