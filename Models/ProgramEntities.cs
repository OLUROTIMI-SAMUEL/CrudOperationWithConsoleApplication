using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Work.Models
{
    public class ProgramEntities
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public List<string> Skills { get; set; }
        public string Benefits { get; set; }
        public string Application { get; set; }
        public string programType { get; set; }

        public DateTime ProgramStart { get; set; }
        public TimeSpan ApplicationSpan { get; set; }
        public DateTime ApplicationClose { get; set; }

        public string Duration { get; set; }
        public string Location { get; set; }
        public string ProgramLocation {get; set;}

        public string MinQualification { get; set; }

        public int NumAppliication { get; set; }

    }
}
