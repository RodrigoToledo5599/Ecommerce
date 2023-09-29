using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ModelsDTO.DTO.MainPageControllerDTO
{
    public class MainPageDTO : AccountDTO
    {
        public IEnumerable<Produto>? produto { get; set; }

    }
}
