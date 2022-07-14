using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.Core.Interfaces;

namespace WebProgramlamaOdev.Core.Models
{
    public class BaseEntity : IEntity
    {
        public int ID { get; set; }
    }
}
