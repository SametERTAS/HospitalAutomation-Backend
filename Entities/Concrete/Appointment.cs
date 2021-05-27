﻿using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        public User Patient { get; set; }
        public User Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public int ExaminationId { get; set; }
    }
}
