﻿// NOTE: This script generated by editor automatically. No need to edit manually!
// ReSharper disable RedundantUsingDirective

using System.Collections.Generic;
using UniSharper.Data.Metadata;
using UniSharper.Extensions;
using UnityEngine;
using UnityEngine.Scripting;
using ColorUtility = UniSharper.Extensions.ColorUtility;

// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedMember.Global

namespace UniSharper.Data.Metadata.Samples
{
	/// <summary>
	/// GenericTypeSampleMetadata
	/// Note: Generated by Editor automatically. Please don't edit this file manually!
	/// </summary>
	public partial class GenericTypeSampleMetadata : MetadataEntity
	{
		/// <summary>
		/// Enum Value
		/// </summary>
		public enum EnumSampleEnum
		{
			None,
			EnumSampleType1
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="GenericTypeSampleMetadata"/> class.
		/// </summary>
		[Preserve]
		public GenericTypeSampleMetadata()
		{
		}

		/// <summary>
		/// ID
		/// </summary>
		public long ID { get; set; }

		/// <summary>
		/// String Value
		/// </summary>
		public string StringSample { get; set; }

		/// <summary>
		/// Boolean Value
		/// </summary>
		public bool BooleanSample { get; set; }

		/// <summary>
		/// Byte Value
		/// </summary>
		public byte ByteSample { get; set; }

		/// <summary>
		/// SByte Value
		/// </summary>
		public sbyte SByteSample { get; set; }

		/// <summary>
		/// Int16 Value
		/// </summary>
		public short Int16Sample { get; set; }

		/// <summary>
		/// UInt16 Value
		/// </summary>
		public ushort UInt16Sample { get; set; }

		/// <summary>
		/// Int32 Value
		/// </summary>
		public int Int32Sample { get; set; }

		/// <summary>
		/// UInt32 Value
		/// </summary>
		public uint UInt32Sample { get; set; }

		/// <summary>
		/// Int64 Value
		/// </summary>
		public long Int64Sample { get; set; }

		/// <summary>
		/// UInt64 Value
		/// </summary>
		public ulong UInt64Sample { get; set; }

		/// <summary>
		/// Single Value
		/// </summary>
		public float SingleSample { get; set; }

		/// <summary>
		/// Double Value
		/// </summary>
		public double DoubleSample { get; set; }

		/// <summary>
		/// Decimal Value
		/// </summary>
		public decimal DecimalSample { get; set; }

		/// <summary>
		/// Enum Value
		/// </summary>
		public int EnumSampleValue { get; set; }

		/// <summary>
		/// Enum Value
		/// </summary>
		public EnumSampleEnum EnumSample => (EnumSampleEnum)EnumSampleValue;

		/// <summary>
		/// String Array Value
		/// </summary>
		public string[] StringArraySample { get; set; }

		/// <summary>
		/// Boolean Array Value
		/// </summary>
		public bool[] BooleanArraySample { get; set; }

		/// <summary>
		/// Byte Array Value
		/// </summary>
		public byte[] ByteArraySample { get; set; }

		/// <summary>
		/// SByte Array Value
		/// </summary>
		public sbyte[] SByteArraySample { get; set; }

		/// <summary>
		/// Int16 Array Value
		/// </summary>
		public short[] Int16ArraySample { get; set; }

		/// <summary>
		/// UInt16 Array Value
		/// </summary>
		public ushort[] UInt16ArraySample { get; set; }

		/// <summary>
		/// Int32 Array Value
		/// </summary>
		public int[] Int32ArraySample { get; set; }

		/// <summary>
		/// UInt32 Array Value
		/// </summary>
		public uint[] UInt32ArraySample { get; set; }

		/// <summary>
		/// Int64 Array Value
		/// </summary>
		public long[] Int64ArraySample { get; set; }

		/// <summary>
		/// UInt64 Array Value
		/// </summary>
		public ulong[] UInt64ArraySample { get; set; }

		/// <summary>
		/// Single Array Value
		/// </summary>
		public float[] SingleArraySample { get; set; }

		/// <summary>
		/// Double Array Value
		/// </summary>
		public double[] DoubleArraySample { get; set; }

		/// <summary>
		/// Decimal Array Value
		/// </summary>
		public decimal[] DecimalArraySample { get; set; }
	}
}
