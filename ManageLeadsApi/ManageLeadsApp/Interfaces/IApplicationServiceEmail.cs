using ManageLeadsApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLeadsApp.Interfaces
{
    public interface IApplicationServiceEmail
    {
        Task<string> SendEmailAsync(EmailDTO emailRequest);
    }
}
