using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    public enum Categorias
    {
        Fone_de_ouvido=1,
        Placa_Programável,
        Monitor,
        Smartphone,
        Placa_mãe,
        Gpu,
        Cpu,
        TV,
        Fonte_de_Alimentação,
        Teclado,
        Mouse,
        SSD,
        HD

    }
    /*
    public enum Categorias2
    {
        "Fone de ouvido"= 1,
        "Placa Programável"=2
        "Monitor",
        "Smartphone",
        "Placa mãe",
        "Gpu",
        "Cpu",
        "TV",
        "Fonte de Alimentação",
        "Teclado",
        "Mouse",
        "SSD",
        "HD"


    }*/

    public enum Roles
    {
        Administrator = 1,
        Usuario = 2,
        Vendedor = 3,


    }
    
}
