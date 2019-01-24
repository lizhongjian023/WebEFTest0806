using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFDal
{
    interface IDbSession
    {
        INews NewsDal { get; set; }
        INewsComments NewsCommentsDal { get; set; }
        IUserInfo UserInfoDal { get; set; }
    }
}
