﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.Faculty
{
    public class UpdateFacultyRequest
    {
        public Guid FacultyId { get; set; }
        public string FacultyName { get; set; }
    }
}
