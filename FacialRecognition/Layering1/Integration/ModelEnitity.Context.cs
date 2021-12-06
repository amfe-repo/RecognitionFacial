﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Layering1.Integration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class UserEntities : DbContext
    {
        public UserEntities()
            : base("name=UserEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<user_tb> user_tb { get; set; }
    
        public virtual int EditarDatos(string nameUser, Nullable<int> age, string enrollment, string firstDose, string secondDose, Nullable<bool> vaccinated, Nullable<bool> roleUser, Nullable<int> idUser)
        {
            var nameUserParameter = nameUser != null ?
                new ObjectParameter("NameUser", nameUser) :
                new ObjectParameter("NameUser", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var enrollmentParameter = enrollment != null ?
                new ObjectParameter("Enrollment", enrollment) :
                new ObjectParameter("Enrollment", typeof(string));
    
            var firstDoseParameter = firstDose != null ?
                new ObjectParameter("FirstDose", firstDose) :
                new ObjectParameter("FirstDose", typeof(string));
    
            var secondDoseParameter = secondDose != null ?
                new ObjectParameter("SecondDose", secondDose) :
                new ObjectParameter("SecondDose", typeof(string));
    
            var vaccinatedParameter = vaccinated.HasValue ?
                new ObjectParameter("Vaccinated", vaccinated) :
                new ObjectParameter("Vaccinated", typeof(bool));
    
            var roleUserParameter = roleUser.HasValue ?
                new ObjectParameter("RoleUser", roleUser) :
                new ObjectParameter("RoleUser", typeof(bool));
    
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditarDatos", nameUserParameter, ageParameter, enrollmentParameter, firstDoseParameter, secondDoseParameter, vaccinatedParameter, roleUserParameter, idUserParameter);
        }
    
        public virtual int EliminarDatos(Nullable<int> idUser)
        {
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarDatos", idUserParameter);
        }
    
        public virtual int InsertarDatos(string nameUser, Nullable<int> age, string enrollment, string firstDose, string secondDose, Nullable<bool> vaccinated, Nullable<bool> roleUser)
        {
            var nameUserParameter = nameUser != null ?
                new ObjectParameter("NameUser", nameUser) :
                new ObjectParameter("NameUser", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var enrollmentParameter = enrollment != null ?
                new ObjectParameter("Enrollment", enrollment) :
                new ObjectParameter("Enrollment", typeof(string));
    
            var firstDoseParameter = firstDose != null ?
                new ObjectParameter("FirstDose", firstDose) :
                new ObjectParameter("FirstDose", typeof(string));
    
            var secondDoseParameter = secondDose != null ?
                new ObjectParameter("SecondDose", secondDose) :
                new ObjectParameter("SecondDose", typeof(string));
    
            var vaccinatedParameter = vaccinated.HasValue ?
                new ObjectParameter("Vaccinated", vaccinated) :
                new ObjectParameter("Vaccinated", typeof(bool));
    
            var roleUserParameter = roleUser.HasValue ?
                new ObjectParameter("RoleUser", roleUser) :
                new ObjectParameter("RoleUser", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarDatos", nameUserParameter, ageParameter, enrollmentParameter, firstDoseParameter, secondDoseParameter, vaccinatedParameter, roleUserParameter);
        }
    
        public virtual ObjectResult<MostrarDatos_Result> MostrarDatos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MostrarDatos_Result>("MostrarDatos");
        }
    }
}
