using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.ViewModel.Users
{
    public class UserRegistryModel
    {
    //    public record UserRegisterModel(Guid Id, DateTime CreatedDate);
      public Guid Id { get; set; }
      public DateTime CreatedDate { get; set; }

    }
}
