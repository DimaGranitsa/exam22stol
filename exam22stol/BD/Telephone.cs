//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exam22stol.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telephone
    {
        public int ID_Telephone { get; set; }
        public string Phonenumbersname { get; set; }
        public Nullable<int> ID_Tupe { get; set; }
        public Nullable<int> ID_Catalog { get; set; }
        public Nullable<int> ID_wrehouse { get; set; }
    
        public virtual Typesoftelephone Typesoftelephone { get; set; }
        public virtual Сatalog Сatalog { get; set; }
    }
}