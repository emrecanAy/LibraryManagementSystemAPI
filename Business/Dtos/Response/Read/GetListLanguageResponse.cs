﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Read
{
    public class GetListLanguageResponse
    {
        public Guid LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}
