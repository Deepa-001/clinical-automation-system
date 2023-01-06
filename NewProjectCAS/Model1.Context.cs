﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewProjectCAS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyDatabseEntities : DbContext
    {
        public MyDatabseEntities()
            : base("name=MyDatabseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<DoctorAppointment> DoctorAppointments { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugDelivery> DrugDeliveries { get; set; }
        public virtual DbSet<Inbox> Inboxes { get; set; }
        public virtual DbSet<MemberLogin> MemberLogins { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientOrderDetail> PatientOrderDetails { get; set; }
        public virtual DbSet<RoleDetail> RoleDetails { get; set; }
        public virtual DbSet<SpecializedData> SpecializedDatas { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
    
        public virtual int InsertDoctor(string firstName, string lastName, Nullable<int> totalExperience, Nullable<int> specializedId, string gender, Nullable<int> memberId)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var totalExperienceParameter = totalExperience.HasValue ?
                new ObjectParameter("TotalExperience", totalExperience) :
                new ObjectParameter("TotalExperience", typeof(int));
    
            var specializedIdParameter = specializedId.HasValue ?
                new ObjectParameter("SpecializedId", specializedId) :
                new ObjectParameter("SpecializedId", typeof(int));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDoctor", firstNameParameter, lastNameParameter, totalExperienceParameter, specializedIdParameter, genderParameter, memberIdParameter);
        }
    
        public virtual int InsertDoctorAppointment(Nullable<int> patientId, Nullable<int> doctorId, string subject, string description, DateTime? appointmentDate, string appointmentStatus)
        {
            var patientIdParameter = patientId.HasValue ?
                new ObjectParameter("PatientId", patientId) :
                new ObjectParameter("PatientId", typeof(int));
    
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("DoctorId", doctorId) :
                new ObjectParameter("DoctorId", typeof(int));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("Subject", subject) :
                new ObjectParameter("Subject", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var appointmentDateParameter = appointmentDate.HasValue ?
                new ObjectParameter("AppointmentDate", appointmentDate) :
                new ObjectParameter("AppointmentDate", typeof(DateTime));
    
            var appointmentStatusParameter = appointmentStatus != null ?
                new ObjectParameter("AppointmentStatus", appointmentStatus) :
                new ObjectParameter("AppointmentStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDoctorAppointment", patientIdParameter, doctorIdParameter, subjectParameter, descriptionParameter, appointmentDateParameter, appointmentStatusParameter);
        }
    
        public virtual int InsertDrugDelivery(Nullable<int> orderId, Nullable<int> supplierId, Nullable<System.DateTime> deliveredDate)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var supplierIdParameter = supplierId.HasValue ?
                new ObjectParameter("SupplierId", supplierId) :
                new ObjectParameter("SupplierId", typeof(int));
    
            var deliveredDateParameter = deliveredDate.HasValue ?
                new ObjectParameter("DeliveredDate", deliveredDate) :
                new ObjectParameter("DeliveredDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDrugDelivery", orderIdParameter, supplierIdParameter, deliveredDateParameter);
        }
    
        public virtual int InsertDrugDetails(string drugName, DateTime? manufactureDate, DateTime? expiredDate, string usedFor, string sideEffects, Nullable<int> totalQuantityAvailable, Nullable<bool> isDeleted)
        {
            var drugNameParameter = drugName != null ?
                new ObjectParameter("DrugName", drugName) :
                new ObjectParameter("DrugName", typeof(string));
    
            var manufactureDateParameter = manufactureDate.HasValue ?
                new ObjectParameter("ManufactureDate", manufactureDate) :
                new ObjectParameter("ManufactureDate", typeof(DateTime));
    
            var expiredDateParameter = expiredDate.HasValue ?
                new ObjectParameter("ExpiredDate", expiredDate) :
                new ObjectParameter("ExpiredDate", typeof(DateTime));
    
            var usedForParameter = usedFor != null ?
                new ObjectParameter("UsedFor", usedFor) :
                new ObjectParameter("UsedFor", typeof(string));
    
            var sideEffectsParameter = sideEffects != null ?
                new ObjectParameter("SideEffects", sideEffects) :
                new ObjectParameter("SideEffects", typeof(string));
    
            var totalQuantityAvailableParameter = totalQuantityAvailable.HasValue ?
                new ObjectParameter("TotalQuantityAvailable", totalQuantityAvailable) :
                new ObjectParameter("TotalQuantityAvailable", typeof(int));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDrugDetails", drugNameParameter, manufactureDateParameter, expiredDateParameter, usedForParameter, sideEffectsParameter, totalQuantityAvailableParameter, isDeletedParameter);
        }
    
        public virtual int InsertMember(string emaiId, string password, Nullable<int> roleId)
        {
            var emaiIdParameter = emaiId != null ?
                new ObjectParameter("EmaiId", emaiId) :
                new ObjectParameter("EmaiId", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertMember", emaiIdParameter, passwordParameter, roleIdParameter);
        }
    
        public virtual int InsertMessage(string fromEmailId, string toEmailId, string subject, string messageDetail, DateTime? messageDate, Nullable<int> replyId, Nullable<bool> isRead)
        {
            var fromEmailIdParameter = fromEmailId != null ?
                new ObjectParameter("FromEmailId", fromEmailId) :
                new ObjectParameter("FromEmailId", typeof(string));
    
            var toEmailIdParameter = toEmailId != null ?
                new ObjectParameter("ToEmailId", toEmailId) :
                new ObjectParameter("ToEmailId", typeof(string));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("Subject", subject) :
                new ObjectParameter("Subject", typeof(string));
    
            var messageDetailParameter = messageDetail != null ?
                new ObjectParameter("MessageDetail", messageDetail) :
                new ObjectParameter("MessageDetail", typeof(string));
    
            var messageDateParameter = messageDate.HasValue ?
                new ObjectParameter("MessageDate", messageDate) :
                new ObjectParameter("MessageDate", typeof(DateTime));
    
            var replyIdParameter = replyId.HasValue ?
                new ObjectParameter("ReplyId", replyId) :
                new ObjectParameter("ReplyId", typeof(int));
    
            var isReadParameter = isRead.HasValue ?
                new ObjectParameter("IsRead", isRead) :
                new ObjectParameter("IsRead", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertMessage", fromEmailIdParameter, toEmailIdParameter, subjectParameter, messageDetailParameter, messageDateParameter, replyIdParameter, isReadParameter);
        }
    
        public virtual int InsertPatient(string firstName, string lastName, DateTime? dateOfBirth, string gender, string address, Nullable<int> memberId)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPatient", firstNameParameter, lastNameParameter, dateOfBirthParameter, genderParameter, addressParameter, memberIdParameter);
        }
    
        public virtual int InsertPatientDrugOrder(Nullable<int> patientId, Nullable<int> drugId, Nullable<int> orderNumber, Nullable<int> quantity, DateTime? orderDate, string orderStatus)
        {
            var patientIdParameter = patientId.HasValue ?
                new ObjectParameter("PatientId", patientId) :
                new ObjectParameter("PatientId", typeof(int));
    
            var drugIdParameter = drugId.HasValue ?
                new ObjectParameter("DrugId", drugId) :
                new ObjectParameter("DrugId", typeof(int));
    
            var orderNumberParameter = orderNumber.HasValue ?
                new ObjectParameter("OrderNumber", orderNumber) :
                new ObjectParameter("OrderNumber", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var orderDateParameter = orderDate.HasValue ?
                new ObjectParameter("OrderDate", orderDate) :
                new ObjectParameter("OrderDate", typeof(DateTime));
    
            var orderStatusParameter = orderStatus != null ?
                new ObjectParameter("OrderStatus", orderStatus) :
                new ObjectParameter("OrderStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPatientDrugOrder", patientIdParameter, drugIdParameter, orderNumberParameter, quantityParameter, orderDateParameter, orderStatusParameter);
        }
    
        public virtual int InsertSupplier(string firstName, string lastName, string companyName, string companyAddresss, Nullable<int> memberId)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var companyAddresssParameter = companyAddresss != null ?
                new ObjectParameter("CompanyAddresss", companyAddresss) :
                new ObjectParameter("CompanyAddresss", typeof(string));
    
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertSupplier", firstNameParameter, lastNameParameter, companyNameParameter, companyAddresssParameter, memberIdParameter);
        }
    
        public virtual int UpdateAdminPassword(Nullable<int> adminId, string password)
        {
            var adminIdParameter = adminId.HasValue ?
                new ObjectParameter("AdminId", adminId) :
                new ObjectParameter("AdminId", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAdminPassword", adminIdParameter, passwordParameter);
        }
    
        public virtual int UpdateAdminProfile(Nullable<int> adminId, string firstName, string lastName, string emailId, string password, string gender, string address)
        {
            var adminIdParameter = adminId.HasValue ?
                new ObjectParameter("AdminId", adminId) :
                new ObjectParameter("AdminId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailIdParameter = emailId != null ?
                new ObjectParameter("EmailId", emailId) :
                new ObjectParameter("EmailId", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAdminProfile", adminIdParameter, firstNameParameter, lastNameParameter, emailIdParameter, passwordParameter, genderParameter, addressParameter);
        }
    
        public virtual int UpdateAppointmentStatus(Nullable<int> appointmentId, string doctorDecision)
        {
            var appointmentIdParameter = appointmentId.HasValue ?
                new ObjectParameter("AppointmentId", appointmentId) :
                new ObjectParameter("AppointmentId", typeof(int));
    
            var doctorDecisionParameter = doctorDecision != null ?
                new ObjectParameter("DoctorDecision", doctorDecision) :
                new ObjectParameter("DoctorDecision", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAppointmentStatus", appointmentIdParameter, doctorDecisionParameter);
        }
    
        public virtual int UpdateDoctor(Nullable<int> memberId, string firstName, string lastName, Nullable<int> totalExperience, Nullable<int> specializedId, string gender)
        {
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var totalExperienceParameter = totalExperience.HasValue ?
                new ObjectParameter("TotalExperience", totalExperience) :
                new ObjectParameter("TotalExperience", typeof(int));
    
            var specializedIdParameter = specializedId.HasValue ?
                new ObjectParameter("SpecializedId", specializedId) :
                new ObjectParameter("SpecializedId", typeof(int));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDoctor", memberIdParameter, firstNameParameter, lastNameParameter, totalExperienceParameter, specializedIdParameter, genderParameter);
        }
    
        public virtual int UpdateDrug(Nullable<int> drugId, Nullable<bool> isDeleted)
        {
            var drugIdParameter = drugId.HasValue ?
                new ObjectParameter("DrugId", drugId) :
                new ObjectParameter("DrugId", typeof(int));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDrug", drugIdParameter, isDeletedParameter);
        }
    
        public virtual int UpdateDrugDeatails(Nullable<int> drugId, string drugName, DateTime? manufactureDate, DateTime? expiredDate, string usedFor, string sideEffects, Nullable<int> totalQuantityAvailable, Nullable<bool> isDeleted)
        {
            var drugIdParameter = drugId.HasValue ?
                new ObjectParameter("DrugId", drugId) :
                new ObjectParameter("DrugId", typeof(int));
    
            var drugNameParameter = drugName != null ?
                new ObjectParameter("DrugName", drugName) :
                new ObjectParameter("DrugName", typeof(string));
    
            var manufactureDateParameter = manufactureDate.HasValue ?
                new ObjectParameter("ManufactureDate", manufactureDate) :
                new ObjectParameter("ManufactureDate", typeof(DateTime));
    
            var expiredDateParameter = expiredDate.HasValue ?
                new ObjectParameter("ExpiredDate", expiredDate) :
                new ObjectParameter("ExpiredDate", typeof(DateTime));
    
            var usedForParameter = usedFor != null ?
                new ObjectParameter("UsedFor", usedFor) :
                new ObjectParameter("UsedFor", typeof(string));
    
            var sideEffectsParameter = sideEffects != null ?
                new ObjectParameter("SideEffects", sideEffects) :
                new ObjectParameter("SideEffects", typeof(string));
    
            var totalQuantityAvailableParameter = totalQuantityAvailable.HasValue ?
                new ObjectParameter("TotalQuantityAvailable", totalQuantityAvailable) :
                new ObjectParameter("TotalQuantityAvailable", typeof(int));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("IsDeleted", isDeleted) :
                new ObjectParameter("IsDeleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDrugDeatails", drugIdParameter, drugNameParameter, manufactureDateParameter, expiredDateParameter, usedForParameter, sideEffectsParameter, totalQuantityAvailableParameter, isDeletedParameter);
        }
    
        public virtual int UpdateDrugDelivery(Nullable<int> orderId, DateTime? deliveredDate)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var deliveredDateParameter = deliveredDate.HasValue ?
                new ObjectParameter("DeliveredDate", deliveredDate) :
                new ObjectParameter("DeliveredDate", typeof(DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDrugDelivery", orderIdParameter, deliveredDateParameter);
        }
    
        public virtual int UpdateIsRead(Nullable<int> messageId, Nullable<bool> isRead)
        {
            var messageIdParameter = messageId.HasValue ?
                new ObjectParameter("MessageId", messageId) :
                new ObjectParameter("MessageId", typeof(int));
    
            var isReadParameter = isRead.HasValue ?
                new ObjectParameter("IsRead", isRead) :
                new ObjectParameter("IsRead", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateIsRead", messageIdParameter, isReadParameter);
        }
    
        public virtual int UpdatePassword(Nullable<int> memberId, string password)
        {
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePassword", memberIdParameter, passwordParameter);
        }
    
        public virtual int UpdatePatient(Nullable<int> memberId, string firstName, string lastName, DateTime? dateOfBirth, string gender, string address)
        {
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePatient", memberIdParameter, firstNameParameter, lastNameParameter, dateOfBirthParameter, genderParameter, addressParameter);
        }
    
        public virtual int UpdatePatientOrderDetails(Nullable<int> orderId, string orderStatus)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var orderStatusParameter = orderStatus != null ?
                new ObjectParameter("OrderStatus", orderStatus) :
                new ObjectParameter("OrderStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePatientOrderDetails", orderIdParameter, orderStatusParameter);
        }
    
        public virtual int UpdateSupplier(Nullable<int> memberId, string firstName, string lastName, string companyName, string companyAddress)
        {
            var memberIdParameter = memberId.HasValue ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var companyAddressParameter = companyAddress != null ?
                new ObjectParameter("CompanyAddress", companyAddress) :
                new ObjectParameter("CompanyAddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSupplier", memberIdParameter, firstNameParameter, lastNameParameter, companyNameParameter, companyAddressParameter);
        }
    }
}