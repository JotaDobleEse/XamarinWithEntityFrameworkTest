using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinWithEntityFramework.Model
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string No { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
