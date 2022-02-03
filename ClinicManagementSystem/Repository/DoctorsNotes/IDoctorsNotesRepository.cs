﻿using ClinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Repository.DoctorsNotes
{
    interface IDoctorsNotesRepository
    {
        Task<List<DoctorNotes>> GetAllNotes();
    }
}