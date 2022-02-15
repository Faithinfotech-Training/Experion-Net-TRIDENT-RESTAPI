﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagementSystem.Models;
using ClinicManagementSystem.View_Models.Appointments;

namespace ClinicManagementSystem.Repository.Appointments
{
    public interface IAppointment
    {
        //view appointments
        Task<List<Appointmentview>> GetAppointments();
        // view Appointment Today
        Task<List<Appointmentview>> GetAppointmentsToday();
        // view Appointment by Date
        Task<List<Appointmentview>> GetAppointmentsByDate(DateTime date);
        //view appointment by id
        Task<Appointmentview> GetAppointmentsById(int id);
        //view appointment using patients mobile
        Task<Appointmentview> GetAppointmentsByPhone(Int64 id);
        //add appointment
        Task<int> AddAppointment(Appointment appointment);
        //update appointment
        Task UpdateAppointment(Appointment appointment);
    
    }
}