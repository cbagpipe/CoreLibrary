//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

using nanoFramework.TestFramework;
using System;

namespace NFUnitTestConversions
{
    [TestClass]
    public class UnitTestBoxingTests
    {
        [TestMethod]
        public void Boxingbyte_Test()
        {
            Assert.True(BoxingTestClassbyte.testMethod());
        }

        [TestMethod]
        public void Boxingchar_Test()
        {
            Assert.True(BoxingTestClasschar.testMethod());
        }

        [TestMethod]
        public void Boxingdouble_Test()
        {
            Assert.True(BoxingTestClassdouble.testMethod());
        }

        [TestMethod]
        public void Boxingfloat_Test()
        {
            Assert.True(BoxingTestClassfloat.testMethod());
        }

        [TestMethod]
        public void Boxingint_Test()
        {
            Assert.True(BoxingTestClassint.testMethod());
        }

        [TestMethod]
        public void Boxinglong_Test()
        {
            Assert.True(BoxingTestClasslong.testMethod());
        }

        [TestMethod]
        public void Boxingsbyte_Test()
        {
            Assert.True(BoxingTestClasssbyte.testMethod());
        }

        [TestMethod]
        public void Boxingshort_Test()
        {
            Assert.True(BoxingTestClassshort.testMethod());
        }

        [TestMethod]
        public void Boxinguint_Test()
        {
            Assert.True(BoxingTestClassuint.testMethod());
        }

        [TestMethod]
        public void Boxingulong_Test()
        {
            Assert.True(BoxingTestClassulong.testMethod());
        }

        [TestMethod]
        public void Boxingushort_Test()
        {
            Assert.True(BoxingTestClassushort.testMethod());
        }

        [TestMethod]
        public void Boxingstruct_to_ValType_Test()
        {
            Assert.True(BoxingTestClassStruct_to_ValType.testMethod());
        }

        [TestMethod]
        public void BoxingValType_to_struct_Test()
        {
            Assert.True(BoxingTestClassValType_to_struct.testMethod());
        }


        //Compiled Test Cases 

        public class BoxingTestClassbyte
        {
            public static bool testMethod()
            {
                byte value = 1;
                object obj;
                obj = value;                    // box
                byte value2;
                value2 = (byte)obj;     // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClasschar
        {
            public static bool testMethod()
            {
                char value = '\x1';
                object obj;
                obj = value;                    // box
                char value2;
                value2 = (char)obj;     // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClassdouble
        {
            public static bool testMethod()
            {
                double value = 1.0;
                object obj;
                obj = value;                    // box
                double value2;
                value2 = (double)obj;       // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClassfloat
        {
            public static bool testMethod()
            {
                float value = 1F;
                object obj;
                obj = value;                    // box
                float value2;
                value2 = (float)obj;        // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClassint
        {
            public static bool testMethod()
            {
                int value = 1;
                object obj;
                obj = value;                    // box
                int value2;
                value2 = (int)obj;      // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClasslong
        {
            public static bool testMethod()
            {
                long value = 1;
                object obj;
                obj = value;                    // box
                long value2;
                value2 = (long)obj;     // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClasssbyte
        {
            public static bool testMethod()
            {
                sbyte value = 1;
                object obj;
                obj = value;                    // box
                sbyte value2;
                value2 = (sbyte)obj;        // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClassshort
        {
            public static bool testMethod()
            {
                short value = 1;
                object obj;
                obj = value;                    // box
                short value2;
                value2 = (short)obj;        // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClassuint
        {
            public static bool testMethod()
            {
                uint value = 1;
                object obj;
                obj = value;                    // box
                uint value2;
                value2 = (uint)obj;     // unbox
                if (value2 == value)
                    return true;
                else
                    return false;

            }
        }


        public class BoxingTestClassulong
        {
            public static bool testMethod()
            {
                ulong value = 1;
                object obj;
                obj = value;                    // box
                ulong value2;
                value2 = (ulong)obj;        // unbox
                if (value2 == value)
                    return true;
                else
                    return false;
            }
        }


        public class BoxingTestClassushort
        {
            public static bool testMethod()
            {
                ushort value = 1;
                object obj;
                obj = value;                    // box
                ushort value2;
                value2 = (ushort)obj;       // unbox
                if (value2 == value)
                    return true;
                else
                    return false;
            }
        }

        struct BoxingTestClassStruct_to_ValTypeTest_struct { }
        class BoxingTestClassStruct_to_ValType
        {
            public static bool testMethod()
            {
                BoxingTestClassStruct_to_ValTypeTest_struct src = new BoxingTestClassStruct_to_ValTypeTest_struct();
                System.ValueType dst = src;
                return true;
            }
        }

        struct BoxingTestClassValType_to_struct_struct { }
        class BoxingTestClassValType_to_struct
        {
            public static bool testMethod()
            {
                System.ValueType src = new BoxingTestClassValType_to_struct_struct();
                BoxingTestClassValType_to_struct_struct dst = (BoxingTestClassValType_to_struct_struct)src;
                return true;
            }
        }

    }
}
