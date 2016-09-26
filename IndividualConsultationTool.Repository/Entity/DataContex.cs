using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace IndividualConsultationTool.Repository.Entity
{
    public class DataContex : DbContext
    {
        public DataContex() : base("ICT_DataBase")
        {
        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<ConsultationChain> ConsultationChains { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Consultation>().HasRequired(c => c.ConsultationChain)
                .WithMany(c => c.Consultations)
                .HasForeignKey(c => c.ChainId);

            modelBuilder.Entity<Consultation>().HasRequired(c => c.Cabinet)
                .WithMany(c => c.Consultations)
                .HasForeignKey(c => c.CabinetId);

            modelBuilder.Entity<Consultation>().HasRequired(p => p.Patient)
                .WithMany(c => c.Consultations)
                .HasForeignKey(c => c.PatientId);

            modelBuilder.Entity<Facture>().HasRequired(c => c.Consultation)
                .WithOptional(c => c.Facture);

            modelBuilder.Entity<Contact>().HasOptional(d => d.Doctor)
                .WithMany(c => c.Contacts)
                .HasForeignKey(c => c.DoctorId);

            modelBuilder.Entity<Cabinet>().HasRequired(d => d.Doctor)
                .WithMany(c => c.Cabinets)
                .HasForeignKey(c => c.DoctorId);

            modelBuilder.Entity<Cabinet>().HasRequired(a => a.Adress)
                .WithOptional(c => c.Cabinet);

            modelBuilder.Entity<Contact>().HasRequired(d => d.Doctor)
                .WithMany(c => c.Contacts)
                .HasForeignKey(d => d.DoctorId);

            modelBuilder.Entity<Patient>().HasRequired(c => c.Contact)
                .WithOptional(c => c.Patient);

            base.OnModelCreating(modelBuilder);
        }
    }
}