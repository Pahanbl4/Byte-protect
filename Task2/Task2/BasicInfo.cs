//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task2
{
    using System;
    using System.Collections.Generic;
    
    public partial class BasicInfo
    {
        public int IdCandidate { get; set; }
        public byte[] Image { get; set; }
        public string Resume { get; set; }
        public string Outcome { get; set; }
    
        public virtual Candidate Candidate { get; set; }
    }
}
