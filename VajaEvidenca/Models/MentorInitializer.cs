using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VajaEvidenca.Models
{
    public class MentorInitializer : DropCreateDatabaseIfModelChanges<Entities>
    {
        protected override void Seed(Entities context)
        {
            var mentorji = new List<Mentor>()
            {
                new Mentor(){ MenId= 1, MenIme= "Barbara", MenPriimek="Pušnar" }
            };
            mentorji.ForEach(p => context.Mentor.Add(p));
            context.SaveChanges();
        }
    }
}