using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VajaEvidenca.Models
{
    public class MentorDeduje
    {
        public int MenId { get; set; }
        public string MenIme { get; set; }
        public string MenPriimek { get; set; }
        public byte[] MenSlika { get; set; }
        public string MenVloga { get; set; }
        public string MenNaziv { get; set; }
        public string MenUstanova { get; set; }
    }
}