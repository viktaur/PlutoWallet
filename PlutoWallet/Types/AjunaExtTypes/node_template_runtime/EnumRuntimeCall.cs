//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace AjunaExample.NetApiExt.Generated.Model.node_template_runtime
{
    
    
    public enum RuntimeCall
    {
        
        System = 0,
        
        Timestamp = 2,
        
        Grandpa = 4,
        
        Balances = 5,
        
        Sudo = 7,
        
        TemplateModule = 8,
        
        BetonEvents = 9,
        
        Nicks = 10,
    }
    
    /// <summary>
    /// >> 114 - Variant[node_template_runtime.RuntimeCall]
    /// </summary>
    public sealed class EnumRuntimeCall : BaseEnumExt<RuntimeCall, AjunaExample.NetApiExt.Generated.Model.frame_system.pallet.EnumCall, BaseVoid, AjunaExample.NetApiExt.Generated.Model.pallet_timestamp.pallet.EnumCall, BaseVoid, AjunaExample.NetApiExt.Generated.Model.pallet_grandpa.pallet.EnumCall, AjunaExample.NetApiExt.Generated.Model.pallet_balances.pallet.EnumCall, BaseVoid, AjunaExample.NetApiExt.Generated.Model.pallet_sudo.pallet.EnumCall>
    {
    }
}