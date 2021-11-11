using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Models
{
    public class Settings
    {
        [Key]
        public int Id { set; get; }

        public int Width { set; get; }

        public int Height { set; get; }

    }
}
