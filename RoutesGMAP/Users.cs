//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoutesGMAP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSecondName { get; set; }
        public string UserCity { get; set; }
        public string UserRegistrationDate { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public bool UserEmailConfirmed { get; set; }
        public bool UserAdminRights { get; set; }
        public byte[] UserPhoto { get; set; }
    }
}