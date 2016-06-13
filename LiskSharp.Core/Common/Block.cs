﻿using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using LiskSharp.Core.Extensions;
using NBitcoin.BouncyCastle.Math;
using Newtonsoft.Json;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class Block
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "version")]
        public int Version { get; set; }

        [DataMember(Name = "totalAmount")]
        public long TotalAmount { get; set; }

        [DataMember(Name = "numberOfTransactions")]
        public int NumberOfTransactions { get; set; }

        [DataMember(Name = "totalFee")]
        public int TotalFee { get; set; }


        [DataMember(Name = "payloadHash")]
        public string PayloadHash { get; set; }


        [DataMember(Name = "timestamp")]
        public int Timestamp { get; set; }


        [DataMember(Name = "payloadLength")]
        public int PayloadLength { get; set; }


        [DataMember(Name = "previousBlock")]
        public BigInteger PreviousBlock { get; set; }


        [DataMember(Name = "generatorPublickKey")]
        public string GeneratorPublicKey { get; set; }


        [DataMember(Name = "transactions")]
        public List<Transaction>  Transactions { get; set; }


        [DataMember(Name = "height")]
        public int Height { get; set; }


        [DataMember(Name = "blockSignature")]
        public string BlockSignature { get; set; }
        public byte[] GetBytes()
        {

            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(Version);
                    writer.Write(Timestamp);
                    if (PreviousBlock != null)
                    {
                        writer.Write(PreviousBlock.ToByteArray());
                    }
                    else
                    {
                        writer.Write(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
                    }
                    writer.Write(NumberOfTransactions);
                    writer.Write(TotalAmount);
                    writer.Write(TotalFee);
                    writer.Write(PayloadLength);
                    writer.Write(PayloadHash.FromHex());
                    writer.Write(GeneratorPublicKey.FromHex());
                    if (!string.IsNullOrWhiteSpace(BlockSignature))
                    {
                        writer.Write(BlockSignature.FromHex());
                    }
                }
                return stream.ToArray();
            }
        }

        public override string ToString()
        {
            var json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}