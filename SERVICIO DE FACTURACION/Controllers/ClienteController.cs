using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

public class ClienteController : ControllerBase{

    public Clientes[] Cliente = new Clientes []{

        new Clientes{Nombre_Cliente="Juan", Apellido_Cliente="Perez",edad=22, Rut="18293129-2"},
        new Clientes{Nombre_Cliente="Roberto", Apellido_Cliente="Martinez", edad=19,Rut="14993432-3"},
        new Clientes{Nombre_Cliente="Felipe", Apellido_Cliente="Correa", edad=30,Rut="17238543-2"},

    };

    public Empresa[] Empresas = new Empresa[]{
        new Empresa{Nombre_Empresa="Luis lt", Rut_Empresa="78328432-2",Giro_Empresa="Comida rapida"},
        new Empresa{Nombre_Empresa="Juan SA", Rut_Empresa="90436532-3",Giro_Empresa="Juegos electronicos"},
        new Empresa{Nombre_Empresa="Mecanica SA", Rut_Empresa="493485473-3",Giro_Empresa="Electronica"},
    };
    
}

        // crear los metodos http get
