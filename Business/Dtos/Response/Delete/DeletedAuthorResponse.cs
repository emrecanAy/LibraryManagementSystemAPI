﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.Delete
{
    public class DeletedAuthorResponse
    {
        public bool IsDeleted { get; set; }

        public DeletedAuthorResponse()
        {
            IsDeleted = true;
        }
    }
}
