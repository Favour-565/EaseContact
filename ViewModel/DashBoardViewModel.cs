using Microsoft.EntityFrameworkCore;
using SQ20.Net_Wee7_8_Task.Models;

namespace SQ20.Net_Wee7_8_Task.ViewModel
{
    public class DashBoardViewModel
    {
        public List<Social> Socials { get; set; }
        public List<Service> Services { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<Education> Educations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<About> Abouts { get; set; }
    }
}
