//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Game
    {
        [DataMember]
        public int game_id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public Nullable<decimal> payout { get; set; }
    }
}
