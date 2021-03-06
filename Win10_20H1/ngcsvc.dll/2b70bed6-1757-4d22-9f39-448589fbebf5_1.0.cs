//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\ngcsvc.dll
// Interface ID: 2b70bed6-1757-4d22-9f39-448589fbebf5
// Interface Version: 1.0



namespace rpc_2b70bed6_1757_4d22_9f39_448589fbebf5_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(byte[] p0, long p1)
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
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public byte[] Read_1()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.WriteEmbeddedPointer<byte[], long>(Member8, new System.Action<byte[], long>(m.Write_1), Member10);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_1), false);
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public int Member10;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, byte[] Member8, int Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("2b70bed6-1757-4d22-9f39-448589fbebf5", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_NgcTicketCreateForKeyOperations(Struct_0 p0, string p1, ref System.Nullable<long> p2, string p3, ref System.Nullable<long> p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p2, new System.Action<long>(m.WriteInt64));
            m.WriteReferent(p3, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p4, new System.Action<long>(m.WriteInt64));
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            p4 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            return u.ReadInt32();
        }
        public int s_NgcTicketCreateForNewKey(Struct_0 p0, System.Guid p1, out long p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            p2 = u.ReadInt64();
            return u.ReadInt32();
        }
        public int s_NgcTicketCreateForSmartCard(Struct_0 p0, string p1, int p2, out long p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(2, m);
            p3 = u.ReadInt64();
            return u.ReadInt32();
        }
        public int s_NgcTicketGetTicketFromPinCache(string p0, int p1, out long p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.ReadInt64();
            return u.ReadInt32();
        }
    }
    #endregion
}

