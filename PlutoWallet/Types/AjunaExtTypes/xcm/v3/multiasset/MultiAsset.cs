//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.xcm.v3.multiasset
{
    
    
    /// <summary>
    /// >> 60 - Composite[xcm.v3.multiasset.MultiAsset]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MultiAsset : BaseType
    {
        
        /// <summary>
        /// >> id
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumAssetId _id;
        
        /// <summary>
        /// >> fun
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumFungibility _fun;
        
        public PlutoWallet.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumAssetId Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumFungibility Fun
        {
            get
            {
                return this._fun;
            }
            set
            {
                this._fun = value;
            }
        }
        
        public override string TypeName()
        {
            return "MultiAsset";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(Fun.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new PlutoWallet.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumAssetId();
            Id.Decode(byteArray, ref p);
            Fun = new PlutoWallet.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumFungibility();
            Fun.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}