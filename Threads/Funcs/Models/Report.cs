using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Report
    {
        public int CompPercent { get; set; } = 0;
        public List<WebsiteDataModel> SitesDownloaded { get; set; } = new List<WebsiteDataModel>();
    }
}
