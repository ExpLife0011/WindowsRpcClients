//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\ws2_32.dll
// Interface ID: 048cf666-ab42-42b4-8975-1357018decb3
// Interface Version: 1.0



namespace rpc_048cf666_ab42_42b4_8975_1357018decb3_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Struct_3[] p0, long p1)
        {
            WriteConformantStructArray<Struct_3>(p0, p1);
        }
        public void Write_7(Struct_4[] p0, long p1)
        {
            WriteConformantStructArray<Struct_4>(p0, p1);
        }
        public void Write_8(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_9(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_10(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_1 Read_0()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_3[] Read_6()
        {
            return ReadConformantStructArray<Struct_3>();
        }
        public Struct_4[] Read_7()
        {
            return ReadConformantStructArray<Struct_4>();
        }
        public byte[] Read_8()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_9()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_10()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<Struct_2>(Member10, new System.Action<Struct_2>(m.Write_1));
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member20);
            m.WriteEmbeddedPointer<System.Guid>(Member28, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteEmbeddedPointer<string>(Member30, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member38);
            m.WriteEmbeddedPointer<Struct_3[], long>(Member40, new System.Action<Struct_3[], long>(m.Write_6), Member38);
            m.WriteEmbeddedPointer<string>(Member48, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member50);
            m.WriteEmbeddedPointer<Struct_4[], long>(Member58, new System.Action<Struct_4[], long>(m.Write_7), Member50);
            m.WriteInt32(Member60);
            m.WriteEmbeddedPointer<Struct_6>(Member68, new System.Action<Struct_6>(m.Write_5));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadEmbeddedPointer<Struct_2>(new System.Func<Struct_2>(u.Read_1), false);
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadInt32();
            Member28 = u.ReadEmbeddedPointer<System.Guid>(new System.Func<System.Guid>(u.ReadGuid), false);
            Member30 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member38 = u.ReadInt32();
            Member40 = u.ReadEmbeddedPointer<Struct_3[]>(new System.Func<Struct_3[]>(u.Read_6), false);
            Member48 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member50 = u.ReadInt32();
            Member58 = u.ReadEmbeddedPointer<Struct_4[]>(new System.Func<Struct_4[]>(u.Read_7), false);
            Member60 = u.ReadInt32();
            Member68 = u.ReadEmbeddedPointer<Struct_6>(new System.Func<Struct_6>(u.Read_5), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_2> Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public int Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<System.Guid> Member28;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member30;
        public int Member38;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_3[]> Member40;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member48;
        public int Member50;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_4[]> Member58;
        public int Member60;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_6> Member68;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, string Member8, System.Nullable<Struct_2> Member10, string Member18, int Member20, System.Nullable<System.Guid> Member28, string Member30, int Member38, Struct_3[] Member40, string Member48, int Member50, Struct_4[] Member58, int Member60, System.Nullable<Struct_6> Member68)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
            this.Member40 = Member40;
            this.Member48 = Member48;
            this.Member50 = Member50;
            this.Member58 = Member58;
            this.Member60 = Member60;
            this.Member68 = Member68;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEnum16(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadEnum16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(int Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_4(Member0);
            m.Write_4(Member10);
            m.WriteInt32(Member20);
            m.WriteInt32(Member24);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_4();
            Member10 = u.Read_4();
            Member20 = u.ReadInt32();
            Member24 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_5 Member0;
        public Struct_5 Member10;
        public int Member20;
        public int Member24;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(Struct_5 Member0, Struct_5 Member10, int Member20, int Member24)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member20 = Member20;
            this.Member24 = Member24;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<byte[], long>(Member0, new System.Action<byte[], long>(m.Write_8), Member8);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_8), false);
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member0;
        public int Member8;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(byte[] Member0, int Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<byte[], long>(Member8, new System.Action<byte[], long>(m.Write_9), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_9), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(int Member0, byte[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("048cf666-ab42-42b4-8975-1357018decb3", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RPCNSPv2Startup(System.Guid p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RPCNSPv2Cleanup(System.Guid p0, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RPCNSPv2LookupServiceBegin(System.Guid p0, Struct_1 p1, int p2, NtApiDotNet.Ndr.Marshal.NdrContextHandle p3, out NtApiDotNet.Ndr.Marshal.NdrUInt3264 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteContextHandle(p3);
            _Unmarshal_Helper u = SendReceive(2, m);
            p4 = u.ReadUInt3264();
            return u.ReadInt32();
        }
        // async
        public int RPCNSPv2LookupServiceNextEx(NtApiDotNet.Ndr.Marshal.NdrUInt3264 p0, int p1, int p2, ref int p3, out byte[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteUInt3264(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(3, m);
            p3 = u.ReadInt32();
            p4 = u.Read_10();
            return u.ReadInt32();
        }
        public int RPCNSPv2LookupServiceEnd(NtApiDotNet.Ndr.Marshal.NdrUInt3264 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteUInt3264(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        // async
        public int RPCNSPv2SetServiceEx(System.Guid p0, Struct_1 p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, int p3, NtApiDotNet.Ndr.Marshal.NdrContextHandle p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.Write_0(p1);
            m.WriteEnum16(p2);
            m.WriteInt32(p3);
            m.WriteContextHandle(p4);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

