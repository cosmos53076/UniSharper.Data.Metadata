﻿using UnityEngine.Scripting;
using UniSharper.Data.Metadata;

namespace UniSharper.Data.Metadata.Example.Entities
{
	/// <summary>
	/// ExampleMetadata
	/// Note: Generated by Editor automatically. Please don't edit this file manually!
	/// </summary>
	public class ExampleMetadata : MetadataEntity
	{
		/// <summary>
		/// Test Enum
		/// </summary>
		public enum TestEnumEnum
		{
			None,
			TestEnumType1
		}

		/// <summary>
		/// Test Enum 2
		/// </summary>
		public enum TestEnum2Enum
		{
			None,
			TestEnum2Type2
		}


		/// <summary>
		/// ID
		/// </summary>
		public long ID
		{
			get;
			set;
		}

		/// <summary>
		/// 测试布尔
		/// test bool
		/// </summary>
		public bool TestBoolean
		{
			get;
			set;
		}

		/// <summary>
		/// test byte
		/// </summary>
		public byte TestByte
		{
			get;
			set;
		}

		/// <summary>
		/// test sbyte
		/// </summary>
		public sbyte TestSByte
		{
			get;
			set;
		}

		/// <summary>
		/// test short
		/// </summary>
		public short TestShort
		{
			get;
			set;
		}

		/// <summary>
		/// test ushort
		/// </summary>
		public ushort TestUShort
		{
			get;
			set;
		}

		/// <summary>
		/// test int
		/// </summary>
		public int TestInt
		{
			get;
			set;
		}

		/// <summary>
		/// test uint
		/// </summary>
		public uint TestUInt
		{
			get;
			set;
		}

		/// <summary>
		/// test ulong
		/// </summary>
		public ulong TestULong
		{
			get;
			set;
		}

		/// <summary>
		/// test float
		/// </summary>
		public float TestFloat
		{
			get;
			set;
		}

		/// <summary>
		/// test double
		/// </summary>
		public double TestDouble
		{
			get;
			set;
		}

		/// <summary>
		/// test decimal
		/// </summary>
		public decimal TestDecimal
		{
			get;
			set;
		}

		/// <summary>
		/// test string
		/// </summary>
		public string TestString
		{
			get;
			set;
		}

		/// <summary>
		/// Test Enum
		/// </summary>
		public int TestEnumIntValue
		{
			get;
			set;
		}

		/// <summary>
		/// Test Enum
		/// </summary>
		public TestEnumEnum TestEnum
		{
			get => (TestEnumEnum)TestEnumIntValue;
		}

		/// <summary>
		/// Test Enum 2
		/// </summary>
		public int TestEnum2IntValue
		{
			get;
			set;
		}

		/// <summary>
		/// Test Enum 2
		/// </summary>
		public TestEnum2Enum TestEnum2
		{
			get => (TestEnum2Enum)TestEnum2IntValue;
		}

		/// <summary>
		/// 测试booleanArray
		/// </summary>
		public bool[] TestBooleanArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试byteArray
		/// </summary>
		public byte[] TestByteArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试sbyteArray
		/// </summary>
		public sbyte[] TestSByteArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试shortArray
		/// </summary>
		public short[] TestShortArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试ushortArray
		/// </summary>
		public ushort[] TestUShortArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试intArray
		/// </summary>
		public int[] TestIntArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试uintArray
		/// </summary>
		public uint[] TestUIntArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试longArray
		/// </summary>
		public long[] TestLongArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试ulongArray
		/// </summary>
		public ulong[] TestULongArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试floatArray
		/// </summary>
		public float[] TestFloatArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试doubleArray
		/// </summary>
		public double[] TestDoubleArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试decimalArray
		/// </summary>
		public decimal[] TestDecimalArray
		{
			get;
			set;
		}

		/// <summary>
		/// 测试stringArray
		/// </summary>
		public string[] TestStringArray
		{
			get;
			set;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ExampleMetadata"/> class.
		/// </summary>
		[Preserve]
		public ExampleMetadata()
			: base()
		{
		}
	}
}
