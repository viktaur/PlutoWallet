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


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_contracts.wasm
{
    
    
    /// <summary>
    /// >> 259 - Composite[pallet_contracts.wasm.PrefabWasmModule]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PrefabWasmModule : BaseType
    {
        
        /// <summary>
        /// >> instruction_weights_version
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _instructionWeightsVersion;
        
        /// <summary>
        /// >> initial
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _initial;
        
        /// <summary>
        /// >> maximum
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _maximum;
        
        /// <summary>
        /// >> code
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT2 _code;
        
        /// <summary>
        /// >> determinism
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.pallet_contracts.wasm.EnumDeterminism _determinism;
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> InstructionWeightsVersion
        {
            get
            {
                return this._instructionWeightsVersion;
            }
            set
            {
                this._instructionWeightsVersion = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Initial
        {
            get
            {
                return this._initial;
            }
            set
            {
                this._initial = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Maximum
        {
            get
            {
                return this._maximum;
            }
            set
            {
                this._maximum = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT2 Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.pallet_contracts.wasm.EnumDeterminism Determinism
        {
            get
            {
                return this._determinism;
            }
            set
            {
                this._determinism = value;
            }
        }
        
        public override string TypeName()
        {
            return "PrefabWasmModule";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(InstructionWeightsVersion.Encode());
            result.AddRange(Initial.Encode());
            result.AddRange(Maximum.Encode());
            result.AddRange(Code.Encode());
            result.AddRange(Determinism.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            InstructionWeightsVersion = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            InstructionWeightsVersion.Decode(byteArray, ref p);
            Initial = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Initial.Decode(byteArray, ref p);
            Maximum = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Maximum.Decode(byteArray, ref p);
            Code = new PlutoWallet.NetApiExt.Generated.Model.sp_core.bounded.weak_bounded_vec.WeakBoundedVecT2();
            Code.Decode(byteArray, ref p);
            Determinism = new PlutoWallet.NetApiExt.Generated.Model.pallet_contracts.wasm.EnumDeterminism();
            Determinism.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
