/*
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
列挙型をジェネリックと併用する際の処理を保持するクラス

Enum.cs
────────────────────────────────────────
バージョン: 1.0.0(250609_1222ベース)
2025 Wataame(HWataame)
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
*/
using System.Runtime.CompilerServices;

namespace System
{
    /// <summary>
    /// 列挙型をジェネリックと併用する際の処理を保持するクラス
    /// </summary>
    /// <typeparam name="T">列挙型</typeparam>
    public class Enum<T> where T : unmanaged, Enum
    {
        /// <summary>
        /// 列挙型のサイズ
        /// </summary>
        private static readonly int enumSize;


        /// <summary>
        /// 初期化処理
        /// </summary>
        static Enum()
        {
            unsafe
            {
                // 列挙型のサイズを取得する
                enumSize = sizeof(T);
            }
        }

        /// <summary>
        /// 8ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(byte value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合
                        byte* p1 = (byte*)pResult;
                        *p1 = value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合
                        ushort* p2 = (ushort*)pResult;
                        *p2 = value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        uint* p4 = (uint*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        ulong* p8 = (ulong*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 8ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(sbyte value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合
                        sbyte* p1 = (sbyte*)pResult;
                        *p1 = value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合
                        short* p2 = (short*)pResult;
                        *p2 = value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        int* p4 = (int*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        long* p8 = (long*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 16ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(ushort value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上1バイトを破棄する)
                        byte* p1 = (byte*)pResult;
                        *p1 = (byte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合
                        ushort* p2 = (ushort*)pResult;
                        *p2 = value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        uint* p4 = (uint*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        ulong* p8 = (ulong*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 16ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(short value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上1バイトを破棄する)
                        sbyte* p1 = (sbyte*)pResult;
                        *p1 = (sbyte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合
                        short* p2 = (short*)pResult;
                        *p2 = value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        int* p4 = (int*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        long* p8 = (long*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 32ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(uint value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上3バイトを破棄する)
                        byte* p1 = (byte*)pResult;
                        *p1 = (byte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合(上2バイトを破棄する)
                        ushort* p2 = (ushort*)pResult;
                        *p2 = (ushort)value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        uint* p4 = (uint*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        ulong* p8 = (ulong*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 32ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(int value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上3バイトを破棄する)
                        sbyte* p1 = (sbyte*)pResult;
                        *p1 = (sbyte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合(上2バイトを破棄する)
                        short* p2 = (short*)pResult;
                        *p2 = (short)value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合
                        int* p4 = (int*)pResult;
                        *p4 = value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        long* p8 = (long*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 64ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(ulong value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上7バイトを破棄する)
                        byte* p1 = (byte*)pResult;
                        *p1 = (byte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合(上6バイトを破棄する)
                        ushort* p2 = (ushort*)pResult;
                        *p2 = (ushort)value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合(上4バイトを破棄する)
                        uint* p4 = (uint*)pResult;
                        *p4 = (uint)value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        ulong* p8 = (ulong*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 64ビット整数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">整数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(long value)
        {
            T result = default;

            unsafe
            {
                T* pResult = &result;
                switch (enumSize)
                {
                    case 1:
                        // ベース型が1バイト型(sbyte、byte)である場合(上7バイトを破棄する)
                        sbyte* p1 = (sbyte*)pResult;
                        *p1 = (sbyte)value;
                        break;
                    case 2:
                        // ベース型が2バイト型(short、ushort)である場合(上6バイトを破棄する)
                        short* p2 = (short*)pResult;
                        *p2 = (short)value;
                        break;
                    case 4:
                        // ベース型が4バイト型(int、uint)である場合(上4バイトを破棄する)
                        int* p4 = (int*)pResult;
                        *p4 = (int)value;
                        break;
                    case 8:
                        // ベース型が8バイト型(long、ulong)である場合
                        long* p8 = (long*)pResult;
                        *p8 = value;
                        break;
                    default:
                        // 非対応の型である場合は既定値を返す
                        return default;
                }
            }

            return result;
        }

        /// <summary>
        /// 実数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">実数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(float value)
        {
            return ToEnum((long)value);
        }

        /// <summary>
        /// 実数値を列挙型の値に変換する
        /// </summary>
        /// <param name="value">実数値</param>
        /// <returns>列挙型の値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToEnum(double value)
        {
            return ToEnum((long)value);
        }

        /// <summary>
        /// 列挙型の値を8ビット整数値に変換する
        /// </summary>
        /// <param name="value">列挙型の値</param>
        /// <returns>整数値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ToByte(T value)
        {
            unsafe
            {
                // 値を取得する
                return *(byte*)&value;
            }
        }

        /// <summary>
        /// 列挙型の値を8ビット整数値に変換する
        /// </summary>
        /// <param name="value">列挙型の値</param>
        /// <returns>整数値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(T value)
        {
            unsafe
            {
                // 値を取得する
                return *(sbyte*)&value;
            }
        }

        /// <summary>
        /// 列挙型の値を16ビット整数値に変換する
        /// </summary>
        /// <param name="value">列挙型の値</param>
        /// <returns>整数値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(T value)
        {
            unsafe
            {
                // 列挙型が16ビット以上であれば16ビット分の値を取得し、
                // 8ビットであれば8ビット分の値を取得する
                return enumSize >= 2 ? *(ushort*)&value : *(byte*)&value;
            }
        }

        /// <summary>
        /// 列挙型の値を16ビット整数値に変換する
        /// </summary>
        /// <param name="value">列挙型の値</param>
        /// <returns>整数値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ToInt16(T value)
        {
            unsafe
            {
                // 列挙型が16ビット以上であれば16ビット分の値を取得し、
                // 8ビットであれば8ビット分の値を取得する
                return enumSize >= 2 ? *(short*)&value : *(sbyte*)&value;
            }
        }

        /// <summary>
        /// 列挙型の値を32ビット整数値に変換する
        /// </summary>
        /// <param name="value">列挙型の値</param>
        /// <returns>整数値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(T value)
        {
            unsafe
            {
                if (enumSize >= 4)
                {
                    // 列挙型が32ビット以上であれば32ビット分の値を取得する
                    return *(uint*)&value;
                }
                else if (enumSize == 2)
                {
                    // 列挙型が16ビットであれば16ビット分の値を取得する
                    return *(ushort*)&value;
                }
                else
                {
                    // 列挙型が8ビットであればビット分の値を取得する
                    return *(byte*)&value;
                }
            }
        }

        /// <summary>
        /// 列挙型の値を32ビット整数値に変換する
        /// </summary>
        /// <param name="value">列挙型の値</param>
        /// <returns>整数値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt32(T value)
        {
            unsafe
            {
                if (enumSize >= 4)
                {
                    // 列挙型が32ビット以上であれば32ビット分の値を取得する
                    return *(int*)&value;
                }
                else if (enumSize == 2)
                {
                    // 列挙型が16ビットであれば16ビット分の値を取得する
                    return *(short*)&value;
                }
                else
                {
                    // 列挙型が8ビットであればビット分の値を取得する
                    return *(sbyte*)&value;
                }
            }
        }

        /// <summary>
        /// 列挙型の値を64ビット整数値に変換する
        /// </summary>
        /// <param name="value">列挙型の値</param>
        /// <returns>整数値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(T value)
        {
            unsafe
            {
                // 列挙型のサイズに応じて値を取得する
                return enumSize switch
                {
                    1 => *(byte*)&value,
                    2 => *(ushort*)&value,
                    4 => *(uint*)&value,
                    8 => *(ulong*)&value,
                    _ => default,
                };
            }
        }

        /// <summary>
        /// 列挙型の値を64ビット整数値に変換する
        /// </summary>
        /// <param name="value">列挙型の値</param>
        /// <returns>整数値</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToInt64(T value)
        {
            unsafe
            {
                // 列挙型のサイズに応じて値を取得する
                return enumSize switch
                {
                    1 => *(sbyte*)&value,
                    2 => *(short*)&value,
                    4 => *(int*)&value,
                    8 => *(long*)&value,
                    _ => default,
                };
            }
        }
    }
}
