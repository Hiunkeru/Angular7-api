﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace angular.api.Models
{
    public class UserViewModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime? Date { get; set; }
        public List<ContentModel> Telefonos { get; set; }
    }

    public class ContentModel
    {
        public string Telefono { get; set; }
    }




}
